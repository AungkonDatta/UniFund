using System;
using System.Drawing;
using System.Windows.Forms;

namespace UniFund
{
    public partial class MemberForm : Form
    {
        private string currentUserName;
        private string currentPassword;
        private LoginForm loginForm;

        public MemberForm(string userName, string password, LoginForm loginForm)
        {
            InitializeComponent();
            currentUserName = userName;
            currentPassword = password;
            this.loginForm = loginForm;

            this.Load += MemberForm_Load;
            this.FormClosing += MemberForm_FormClosing;

            Pbtn.Click += Pbtn_Click;
            Dashbtn.Click += Dashbtn_Click;
            Logoutbtn.Click += Logoutbtn_Click;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new UserProfileForm(currentUserName, currentPassword));
        }

        private void MemberForm_FormClosing(object sender, FormClosingEventArgs e)
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
                Math.Max(0, (FormPanel.Width - childForm.Width) / 2),
                Math.Max(0, (FormPanel.Height - childForm.Height) / 2)
            );

            childForm.Show();
        }

        private void Pbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserProfileForm(currentUserName, currentPassword));
        }

        private void Dashbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MemberDashboardForm());
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
