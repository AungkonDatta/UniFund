using System;
using System.Drawing;
using System.Windows.Forms;

namespace UniFund
{
    public partial class CashierForm : Form
    {
        private string currentUserName;
        private string currentPassword;
        private LoginForm loginForm;

        public CashierForm(string userName, string password, LoginForm loginForm)
        {
            InitializeComponent();
            currentUserName = userName;
            currentPassword = password;
            this.loginForm = loginForm;

            this.Load += CashierForm_Load;
            this.FormClosing += CashierForm_FormClosing;

            Pbtn.Click += Pbtn_Click;
            Dbtn.Click += Dbtn_Click;
            Lbtn.Click += Lbtn_Click;
            Logoutbtn.Click += Logoutbtn_Click;
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new UserProfileForm(currentUserName, currentPassword));
        }

        private void CashierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loginForm.Visible)
                Application.Exit();
        }

        private void OpenChildForm(Form childForm)
        {
            FormPanel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            FormPanel.Controls.Add(childForm);
            FormPanel.Tag = childForm;

            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(
                (FormPanel.Width - childForm.Width) / 2,
                (FormPanel.Height - childForm.Height) / 2
            );

            childForm.Show();
        }

        private void Pbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserProfileForm(currentUserName, currentPassword));
        }

        private void Dbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DepositForm());
        }

        private void Lbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoanForm());
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.ClearFields();
            loginForm.Show();
            this.Close();
        }
    }
}
