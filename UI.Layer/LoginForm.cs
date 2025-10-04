using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UniFund
{
    public partial class LoginForm : Form
    {
        DataAccess dataAccess;

        public LoginForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            this.FormClosing += LoginForm_FormClosing;
            this.Shown += LoginForm_Shown;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // exit app if user closes login form
        }

        public void ClearFields()
        {
            UserNameTxtBox.Text = "";
            PasswordTxtBox.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxtBox.Text.Trim();
            string password = PasswordTxtBox.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string sql = "SELECT UserName, Role FROM Users WHERE UserName=@UserName AND Password=@Password";
            SqlCommand cmd = dataAccess.GetCommand(sql);
            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@Password", password);

            DataTable dt = dataAccess.Execute(cmd);

            if (dt.Rows.Count > 0)
            {
                string dbUserName = dt.Rows[0]["UserName"].ToString();
                string role = dt.Rows[0]["Role"].ToString();

                // Show welcome message
                MessageBox.Show($"Login successful! Welcome {dbUserName} ({role}).", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // hide login form

                // Pass "this" to role forms to reuse login form on logout
                if (role == "Admin")
                {
                    AdminForm admin = new AdminForm(userName, password, this);
                    admin.StartPosition = FormStartPosition.Manual;
                    admin.Location = this.Location;
                    admin.Show();
                }
                else if (role == "Cashier")
                {
                    CashierForm cashier = new CashierForm(userName, password, this);
                    cashier.StartPosition = FormStartPosition.Manual;
                    cashier.Location = this.Location;
                    cashier.Show();
                }
                else
                {
                    MemberForm member = new MemberForm(userName, password, this);
                    member.StartPosition = FormStartPosition.Manual;
                    member.Location = this.Location;
                    member.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }
    }
}
