using Repositories.Entities;
using Repositories.Repositories;
using Services;

namespace BOOKSTORE_CONGNTT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtUsername.Text;
            string password = txtPassword.Text;
            BookManagementMemberService se = new BookManagementMemberService(); ;

            BookManagementMember account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            if (account.MemberRole != 1)
            {
                MessageBox.Show("You are not allowed to access this function!",
                                "Access denied", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            BookManagementForm bookMgt = new BookManagementForm();
            bookMgt.Show(); //show form CRUD
            this.Hide();
        }



    }
}