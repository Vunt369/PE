using Services.MethodCRUD;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE
{
    public partial class AddNewAccount : Form
    {

        BankAccountTypeContext context;
        BankAccountRepository bankAccountRepository = new BankAccountRepository();
        private DataTable accountTable = new DataTable();
        public AddNewAccount()
        {
            InitializeComponent();
            context = new BankAccountTypeContext();
        }
        public void setUpCB()
        {
            cbbTypeId.Items.Add("AT0001");
            cbbTypeId.Items.Add("AT0002");
            cbbTypeId.Items.Add("AT0003");
            cbbTypeId.Items.Add("AT0004");
            cbcName.Items.Add("Saving Account Description");
            cbcName.Items.Add("Checking Account Description");
            cbcName.Items.Add("Trading Account Description");
            cbcName.Items.Add("Money Market Account Description");

        }
        public static bool StartsWithUper(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            return char.IsUpper(s[0]);
        }
        public static bool CheckNullStr(string s)
        {
            return String.IsNullOrEmpty(s);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountId = txtAccountId.Text.Trim();
            bankAccount.AccountName = cbcName.Text.Trim();
            bankAccount.OpenDate = dtpDate.Value;
            bankAccount.BranchName = txtBranch.Text.Trim();
            bankAccount.TypeId = cbbTypeId.Text.Trim();
            if (CheckNullStr(bankAccount.AccountId))
            {
                MessageBox.Show("Please input AccountId!");
            }
            else
            {
                if (CheckNullStr(bankAccount.AccountName))
                {
                    MessageBox.Show("Please input Account Name!");
                }
                else
                {
                    if (bankAccount.OpenDate.Value.Year < 2000 || bankAccount.OpenDate.Value.Year > 2023)
                    {
                        MessageBox.Show("Year of open must between 2000 and 2022");
                    }
                    else
                    {
                        if (CheckNullStr(bankAccount.BranchName))
                        {
                            MessageBox.Show("Please input Branch Name!");
                        }
                        else
                        {
                            if (StartsWithUper(bankAccount.BranchName) == false)
                            {
                                MessageBox.Show("The Branch Name must begin with the capital letter");
                            }
                            else
                            {
                                if (CheckNullStr(bankAccount.TypeId))
                                {
                                    MessageBox.Show("Please input TypeId!");
                                }
                                else
                                {
                                    if (context.BankAccounts.Where(p => p.TypeId.Equals(bankAccount.TypeId)).FirstOrDefault() != null)
                                    {

                                        bankAccountRepository.add(bankAccount);
                                        MessageBox.Show("Create successfully!!");
                                        this.Hide();
                                        Form frManagement = new AdminCRUDForm();
                                        frManagement.ShowDialog();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Create Fail!");
                                    }
                                }
                            }
                        }

                    }

                }
            }

   
            
             

        }

    }
}
