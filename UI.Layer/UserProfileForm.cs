using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UniFund
{
    public partial class UserProfileForm : Form
    {
        private DataAccess dataAccess;
        private string currentUserName;
        private string currentPassword;
        private readonly string picturesPath =
            @"C:\Users\HP 840 G5\OneDrive - American International University-Bangladesh\Desktop\C# Project\UniFund\UI.Layer\Pictures";

        public UserProfileForm(string userName, string password)
        {
            InitializeComponent();
            dataAccess = new DataAccess();

            currentUserName = userName;
            currentPassword = password;

            this.Load += UserProfileForm_Load;
            EditPassBtn.Click += EditPasswordBtn_Click;
            SaveBtn.Click += SaveBtn_Click;

            // Paint "Picture not found" text when empty
            UserPictureBox.Paint += UserPictureBox_Paint;
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            // Ensure pictures folder exists (optional)
            if (!Directory.Exists(picturesPath))
                Directory.CreateDirectory(picturesPath);

            // Fill fields
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            try
            {
                // set username/password from constructor parameters
                UserNameTxtBox.Text = currentUserName;
                PasswordTxtBox.Text = currentPassword;

                // read Role from DB (we only need role here)
                string query = "SELECT Role FROM Users WHERE UserName=@UserName";
                SqlCommand cmd = dataAccess.GetCommand(query);
                cmd.Parameters.AddWithValue("@UserName", currentUserName);
                DataTable dt = dataAccess.Execute(cmd);
                if (dt.Rows.Count > 0)
                {
                    URtextBox.Text = dt.Rows[0]["Role"].ToString();
                }

                // default readonly
                UserNameTxtBox.ReadOnly = true;
                PasswordTxtBox.ReadOnly = true;
                URtextBox.ReadOnly = true;

                // load picture (does not lock file)
                LoadUserPicture(currentUserName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void LoadUserPicture(string userName)
        {
            string path = Path.Combine(picturesPath, $"{userName}.jpg");
            if (File.Exists(path))
            {
                // load image into memory copy so that file isn't locked
                try
                {
                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        Image loaded = Image.FromStream(fs);
                        // make a copy so stream can be disposed
                        UserPictureBox.Image = new Bitmap(loaded);
                    }
                }
                catch
                {
                    // fallback: clear image if something goes wrong
                    UserPictureBox.Image = null;
                }
            }
            else
            {
                UserPictureBox.Image = null; // triggers paint to show text
            }
        }

        private void UserPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (UserPictureBox.Image == null)
            {
                using (Font font = new Font("Segoe UI", 10, FontStyle.Regular))
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    // Show "Picture not found" when no image exists
                    string textToShow = "Picture not found";
                    e.Graphics.DrawString(textToShow, font, brush, UserPictureBox.ClientRectangle, sf);
                }
            }
        }

        private void EditPasswordBtn_Click(object sender, EventArgs e)
        {
            // make only password editable
            PasswordTxtBox.ReadOnly = false;
            PasswordTxtBox.Focus();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = PasswordTxtBox.Text?.Trim() ?? "";

                if (string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Password cannot be empty.");
                    return;
                }

                string updateQuery = "UPDATE Users SET Password=@Password WHERE UserName=@UserName";
                SqlCommand cmd = dataAccess.GetCommand(updateQuery);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@UserName", currentUserName);

                int rowsAffected = dataAccess.ExecuteNonQuery(cmd);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully.");
                    PasswordTxtBox.ReadOnly = true;
                    currentPassword = newPassword; // update local
                }
                else
                {
                    MessageBox.Show("Failed to update password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving password: " + ex.Message);
            }
        }
    }
}
