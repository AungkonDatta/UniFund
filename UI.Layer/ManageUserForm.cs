using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UniFund
{
    public partial class ManageUserForm : Form
    {
        private DataAccess dataAccess;
        private string originalUserName = null;
        private string originalRole = null;
        private string selectedPicturePath = null; // Temp path of selected picture
        private readonly string picturesPath =
            @"C:\Users\HP 840 G5\OneDrive - American International University-Bangladesh\Desktop\C# Project\UniFund\UI.Layer\Pictures";

        public ManageUserForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();

            Addbtn.Click += Addbtn_Click;
            Updatebtn.Click += Updatebtn_Click;
            Deletebtn.Click += Deletebtn_Click;
            UserGridView.CellClick += UserGridView_CellClick;
            UserGridView.CellDoubleClick += UserGridView_CellDoubleClick;
            this.Load += ManageUserForm_Load;

            UserGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserGridView.MultiSelect = false;
            RoleComboBox.SelectedIndexChanged += RoleComboBox_SelectedIndexChanged;

            // PictureBox events
            UserPictureBox.Click += UserPictureBox_Click;
            UserPictureBox.Paint += UserPictureBox_Paint;

            // Ensure picture folder exists
            if (!Directory.Exists(picturesPath))
                Directory.CreateDirectory(picturesPath);
        }

        private void ManageUserForm_Load(object sender, EventArgs e)
        {
            RoleComboBox.SelectedIndex = 0;
            LoadUsers();
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (RoleComboBox.SelectedItem == null) return;

            try
            {
                string role = RoleComboBox.SelectedItem.ToString();
                string query = "SELECT UserName, Password, Role FROM Users WHERE Role=@Role";

                SqlCommand cmd = dataAccess.GetCommand(query);
                cmd.Parameters.AddWithValue("@Role", role);

                DataTable dt = dataAccess.Execute(cmd);

                UserGridView.AutoGenerateColumns = false;
                UserGridView.DataSource = dt;

                UserGridView.Columns["UserName"].DataPropertyName = "UserName";
                UserGridView.Columns["Password"].DataPropertyName = "Password";
                UserGridView.Columns["Role"].DataPropertyName = "Role";

                UserGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= PICTURE =================
        private void UserPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedPicturePath = ofd.FileName;
                    UserPictureBox.Image = Image.FromFile(selectedPicturePath);
                    UserPictureBox.Invalidate();
                }
            }
        }

        private void SaveUserPicture(string userName)
        {
            if (string.IsNullOrEmpty(userName)) return;

            if (!string.IsNullOrEmpty(selectedPicturePath) && File.Exists(selectedPicturePath))
            {
                string destFile = Path.Combine(picturesPath, $"{userName}.jpg");

                // Resize before saving
                using (Image img = Image.FromFile(selectedPicturePath))
                using (Bitmap resized = new Bitmap(img, UserPictureBox.Size))
                {
                    resized.Save(destFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void UpdateUserPicture(string oldUserName, string newUserName)
        {
            string oldPath = Path.Combine(picturesPath, $"{oldUserName}.jpg");
            string newPath = Path.Combine(picturesPath, $"{newUserName}.jpg");

            try
            {
                // If user did not select a new picture → just rename
                if (File.Exists(oldPath) && string.IsNullOrEmpty(selectedPicturePath))
                {
                    if (oldPath != newPath)
                    {
                        File.Move(oldPath, newPath);
                    }
                }
                // If a new picture was selected → overwrite
                else if (!string.IsNullOrEmpty(selectedPicturePath) && File.Exists(selectedPicturePath))
                {
                    using (Image img = Image.FromFile(selectedPicturePath))
                    using (Bitmap resized = new Bitmap(img, UserPictureBox.Size))
                    {
                        resized.Save(newPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating picture: " + ex.Message);
            }
        }

        private void LoadUserPicture(string userName)
        {
            string path = Path.Combine(picturesPath, $"{userName}.jpg");
            if (File.Exists(path))
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    UserPictureBox.Image = Image.FromStream(stream);
                }
            }
            else
            {
                UserPictureBox.Image = null;
                UserPictureBox.Invalidate();
            }
        }

        private void UserPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (UserPictureBox.Image == null)
            {
                using (Font font = new Font("Arial", 10, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    e.Graphics.DrawString("Select Picture", font, brush, UserPictureBox.ClientRectangle, sf);
                }
            }
        }

        // ================= ADD =================
        private void Addbtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxtBox.Text;
            string password = PasswordTxtBox.Text;
            string role = RoleComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Username, Password and Role are required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sqlUser = "INSERT INTO Users (UserName, Password, Role) VALUES (@UserName, @Password, @Role)";
                SqlCommand cmdUser = dataAccess.GetCommand(sqlUser);
                cmdUser.Parameters.AddWithValue("@UserName", userName);
                cmdUser.Parameters.AddWithValue("@Password", password);
                cmdUser.Parameters.AddWithValue("@Role", role);
                dataAccess.ExecuteNonQuery(cmdUser);

                string sqlDeposit = @"INSERT INTO Deposit 
                    (UserName, Balance, Penalty, Interest, LastDepositAmount, LastDepositYear, LastDepositMonth, LastDepositDate)
                    VALUES 
                    (@UserName, 0, 0, 0, 0, NULL, NULL, NULL)";
                SqlCommand cmdDeposit = dataAccess.GetCommand(sqlDeposit);
                cmdDeposit.Parameters.AddWithValue("@UserName", userName);
                dataAccess.ExecuteNonQuery(cmdDeposit);

                SaveUserPicture(userName);

                LoadUsers();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        // ================= UPDATE =================
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (originalUserName == null || originalRole == null)
            {
                MessageBox.Show("Please double-click a row to update.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newUserName = UserNameTxtBox.Text;
            string newPassword = PasswordTxtBox.Text;
            string newRole = RoleComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(newUserName) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(newRole))
            {
                MessageBox.Show("Username, Password and Role are required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sqlUser = "UPDATE Users SET UserName=@NewUserName, Password=@Password, Role=@NewRole " +
                                 "WHERE UserName=@OldUserName AND Role=@OldRole";
                SqlCommand cmdUser = dataAccess.GetCommand(sqlUser);
                cmdUser.Parameters.AddWithValue("@NewUserName", newUserName);
                cmdUser.Parameters.AddWithValue("@Password", newPassword);
                cmdUser.Parameters.AddWithValue("@NewRole", newRole);
                cmdUser.Parameters.AddWithValue("@OldUserName", originalUserName);
                cmdUser.Parameters.AddWithValue("@OldRole", originalRole);
                dataAccess.ExecuteNonQuery(cmdUser);

                string sqlDeposit = "UPDATE Deposit SET UserName=@NewUserName WHERE UserName=@OldUserName";
                SqlCommand cmdDeposit = dataAccess.GetCommand(sqlDeposit);
                cmdDeposit.Parameters.AddWithValue("@NewUserName", newUserName);
                cmdDeposit.Parameters.AddWithValue("@OldUserName", originalUserName);
                dataAccess.ExecuteNonQuery(cmdDeposit);

                UpdateUserPicture(originalUserName, newUserName);

                LoadUsers();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        // ================= DELETE =================
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (UserGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userName = UserGridView.SelectedRows[0].Cells["UserName"].Value.ToString();
            string role = UserGridView.SelectedRows[0].Cells["Role"].Value.ToString();

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string sqlDeposit = "DELETE FROM Deposit WHERE UserName=@UserName";
                SqlCommand cmdDeposit = dataAccess.GetCommand(sqlDeposit);
                cmdDeposit.Parameters.AddWithValue("@UserName", userName);
                dataAccess.ExecuteNonQuery(cmdDeposit);

                string sqlUser = "DELETE FROM Users WHERE UserName=@UserName AND Role=@Role";
                SqlCommand cmdUser = dataAccess.GetCommand(sqlUser);
                cmdUser.Parameters.AddWithValue("@UserName", userName);
                cmdUser.Parameters.AddWithValue("@Role", role);
                dataAccess.ExecuteNonQuery(cmdUser);

                string picPath = Path.Combine(picturesPath, $"{userName}.jpg");
                if (File.Exists(picPath)) File.Delete(picPath);

                LoadUsers();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        // ================= GRID EVENTS =================
        private void UserGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UserGridView.ClearSelection();
                ClearInputs();
            }
        }

        private void UserGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UserGridView.ClearSelection();
                UserGridView.Rows[e.RowIndex].Selected = true;

                originalUserName = UserGridView.Rows[e.RowIndex].Cells["UserName"].Value?.ToString();
                originalRole = UserGridView.Rows[e.RowIndex].Cells["Role"].Value?.ToString();

                UserNameTxtBox.Text = originalUserName;
                PasswordTxtBox.Text = UserGridView.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? "";

                RoleComboBox.SelectedIndexChanged -= RoleComboBox_SelectedIndexChanged;
                RoleComboBox.SelectedItem = originalRole;
                RoleComboBox.SelectedIndexChanged += RoleComboBox_SelectedIndexChanged;

                LoadUserPicture(originalUserName);
            }
        }

        private void ClearInputs()
        {
            UserNameTxtBox.Text = "";
            PasswordTxtBox.Text = "";
            originalUserName = null;
            originalRole = null;
            selectedPicturePath = null;
            UserPictureBox.Image = null;
            UserPictureBox.Invalidate();
        }
    }
}
