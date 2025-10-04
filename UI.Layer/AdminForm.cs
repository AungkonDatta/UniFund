using System;
using System.Drawing;
using System.Windows.Forms;

namespace UniFund
{
    public partial class AdminForm : Form
    {
        private string currentUserName;
        private string currentPassword;
        private LoginForm loginForm;

        public AdminForm(string userName, string password, LoginForm loginForm)
        {
            InitializeComponent();
            currentUserName = userName;
            currentPassword = password;
            this.loginForm = loginForm;

            this.Load += AdminForm_Load;
            this.FormClosing += AdminForm_FormClosing;

            Pbtn.Click += Pbtn_Click;
            MUbtn.Click += MUbtn_Click;
            Logoutbtn.Click += Logoutbtn_Click;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new UserProfileForm(currentUserName, currentPassword));
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit application if user closes window manually
            if (!this.loginForm.Visible)
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

        private void MUbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageUserForm());
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
