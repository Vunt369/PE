using Services.Models;

namespace PE
{
    public partial class Login : Form
    {
        BankAccountTypeContext context;
        public Login()
        {
            InitializeComponent();
            context = new BankAccountTypeContext();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (username == null || password == null)
            {
                MessageBox.Show("Invalid username or password", "Thong bao", MessageBoxButtons.OK);

            }
            else if (context.Users.Where(p => p.UserName.Equals(username) && p.Password.Equals(password)).FirstOrDefault() != null)
            {
                //dang nhap thanh cong
                //MessageBox.Show("Dang nhap thanh cong", "Thong bao", MessageBoxButtons.OK);

                if (username.Equals("Administrator"))
                {
                    this.Hide();
                    Form frManagement = new AdminCRUDForm();
                    frManagement.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You are not allowed to access this function!", "Thong bao", MessageBoxButtons.OK);
                    //dang nhap that bai
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Thong bao", MessageBoxButtons.OK);
            }
        }
    }
}