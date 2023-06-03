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
    public partial class AdminCRUDForm : Form
    {
        BankAccountTypeContext _bankAccountTypeContext;
        private DataTable accountTable = new DataTable();
        public AdminCRUDForm()
        {
            InitializeComponent();
            _bankAccountTypeContext = new BankAccountTypeContext();
            var listBankAccount = _bankAccountTypeContext.BankAccounts.ToList();
            dgv_UserAccount.DataSource = new BindingSource { DataSource = listBankAccount };
        }
        public void loadBankAccount(string BranchName)
        {
            var listBankAccount = _bankAccountTypeContext.BankAccounts.ToList();
          
           
            if (BranchName != null)
            {
                listBankAccount = listBankAccount.Where(p => p.BranchName.ToUpper().Contains(BranchName.ToUpper())).ToList();
            }
            dgv_UserAccount.DataSource = new BindingSource { DataSource = listBankAccount };
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = txtSearchValue.Text;
            loadBankAccount(search);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frManagement = new AddNewAccount();
            frManagement.ShowDialog();

            var listBankAccount = _bankAccountTypeContext.BankAccounts.ToList();
            dgv_UserAccount.DataSource = new BindingSource { DataSource = listBankAccount };
        }

        public void resetStatus()
        {
            btnCreate.Visible = true;
            btnDelete.Visible = true;
            btnClose.Visible = true;
        }
        /*   private void dgv_UserAccount_CellClick(object sender, DataGridViewCellEventArgs e)
           {

               DataGridView dgv = (DataGridView)sender;
               var listBankAccount = _bankAccountTypeContext.BankAccounts.ToList();
               // update input field
               if (e.RowIndex == dgv.Rows.Count - 1 || e.RowIndex == -1)
               {
                   resetStatus();
               }
               else
               {
                   var bankAccount = listBankAccount[e.RowIndex];
                   txtAccountId.ReadOnly = true;
                   txtAccountId.Text = bankAccount.AccountId.ToString();
                   txtName.Text = bankAccount.AccountName.ToString();
                   txtBranch.Text = bankAccount.BranchName.ToString();
                   txtTypeId.Text = bankAccount.TypeId.ToString();

                   //update button state
                   btnCreate.Visible = false;
                   btnDelete.Visible = true;
                   btnUpdate.Visible = true;
                   btnClose.Visible = false;
               }
           }*/


        private void btnDelete_Click(object sender, EventArgs e)
        {
            BankAccountRepository bankAccountRepository = new BankAccountRepository();
            
            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountId = dgv_UserAccount.CurrentRow.Cells[0].Value.ToString();
            bankAccount.AccountName = dgv_UserAccount.CurrentRow.Cells[1].Value.ToString();
            bankAccount.OpenDate = DateTime.Now;
            bankAccount.BranchName = dgv_UserAccount.CurrentRow.Cells[3].Value.ToString();
            bankAccount.TypeId = dgv_UserAccount.CurrentRow.Cells[4].Value.ToString();

            if (_bankAccountTypeContext.BankAccounts.Where(p => p.TypeId.Equals(bankAccount.AccountId)).FirstOrDefault() == null)
            {
                bankAccountRepository.remove(bankAccount);
                MessageBox.Show("Delete Successfull!!");
                resetStatus();
            }
            else
            {
                MessageBox.Show("Delete fault!!");
            }
            var listBankAccount = _bankAccountTypeContext.BankAccounts.ToList();
            dgv_UserAccount.DataSource = new BindingSource { DataSource = listBankAccount };
        }

        public void dgv_UserAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateAccount f2 = new UpdateAccount();
            f2.txtAccountId.Text = dgv_UserAccount.CurrentRow.Cells[0].Value.ToString();
            f2.cbcName.Text = dgv_UserAccount.CurrentRow.Cells[1].Value.ToString();
            f2.dtpDate.Text = dgv_UserAccount.CurrentRow.Cells[2].Value.ToString();
            f2.txtBranch.Text = dgv_UserAccount.CurrentRow.Cells[3].Value.ToString();
            f2.cbbTypeId.Text = dgv_UserAccount.CurrentRow.Cells[4].Value.ToString();
            f2.txtAccountId.ReadOnly = true;
            this.Hide();
            f2.ShowDialog();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
