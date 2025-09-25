using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace UniFund
{
    public partial class DepositForm : Form
    {
        private DataAccess db;

        public DepositForm()
        {
            InitializeComponent();
            db = new DataAccess();

            DepositBtn.Click += DepositBtn_Click;
            MemberGridView.CellClick += MemberGridView_CellClick;
            this.Load += DepositForm_Load;

            MemberGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MemberGridView.MultiSelect = false;
        }

        // ================== FORM LOAD ==================
        private void DepositForm_Load(object sender, EventArgs e)
        {
            // Year picker setup
            YearPicker.Format = DateTimePickerFormat.Custom;
            YearPicker.CustomFormat = "yyyy";
            YearPicker.ShowUpDown = true;

            // Month picker setup
            MonthPicker.Format = DateTimePickerFormat.Custom;
            MonthPicker.CustomFormat = "MMMM"; // Full month name
            MonthPicker.ShowUpDown = true;

            LoadMembers();
        }

        // ================== LOAD GRID ==================
        private void LoadMembers()
        {
            try
            {
                // Include LastDepositDate in the SELECT query
                string query = "SELECT UserName, Balance, LastDepositMonth, LastDepositDate FROM Deposit";
                DataTable dt = db.Execute(query);

                MemberGridView.AutoGenerateColumns = false;
                MemberGridView.DataSource = dt;

                // Bind columns
                MemberGridView.Columns["UserName"].DataPropertyName = "UserName";
                MemberGridView.Columns["Balance"].DataPropertyName = "Balance";
                MemberGridView.Columns["LastDepositMonth"].DataPropertyName = "LastDepositMonth";
                MemberGridView.Columns["LastDepositDate"].DataPropertyName = "LastDepositDate";

                MemberGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message);
            }
        }

        // ================== GRID CLICK ==================
        private void MemberGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MemberGridView.Rows[e.RowIndex].Selected = true;

                // Only set the UserNameTxtBox
                string userName = MemberGridView.Rows[e.RowIndex].Cells["UserName"].Value?.ToString();
                UserNameTxtBox.Text = userName;

                // Clear other fields
                AmountTxtBox.Clear();
                PenaltyTxtBox.Clear();
                YearPicker.Value = DateTime.Now;
                MonthPicker.Value = DateTime.Now;

                // Load last deposit month safely
                string sql = "SELECT LastDepositYear, LastDepositMonth FROM Deposit WHERE UserName=@UserName";
                SqlCommand cmd = db.GetCommand(sql);
                cmd.Parameters.AddWithValue("@UserName", userName);
                DataTable dt = db.Execute(cmd);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    if (row["LastDepositYear"] != DBNull.Value && row["LastDepositMonth"] != DBNull.Value)
                    {
                        int year = Convert.ToInt32(row["LastDepositYear"]);
                        string monthName = row["LastDepositMonth"].ToString();

                        // Convert month name to month number
                        int month = DateTime.ParseExact(monthName, "MMMM", CultureInfo.InvariantCulture).Month;

                        // Set pickers
                        YearPicker.Value = new DateTime(year, 1, 1);
                        MonthPicker.Value = new DateTime(year, month, 1); // MonthPicker will show name
                    }
                }
            }
        }

        // ================== DEPOSIT BUTTON ==================
        private void DepositBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxtBox.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please select a member first.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(AmountTxtBox.Text, out decimal depositAmount))
            {
                MessageBox.Show("Invalid amount.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(PenaltyTxtBox.Text, out decimal penalty))
            {
                penalty = 0;
            }

            int year = YearPicker.Value.Year;
            string monthName = MonthPicker.Value.ToString("MMMM"); // Store month as name
            DateTime depositDate = DateTime.Now;

            try
            {
                // Update balance
                string updateSql = @"
                    UPDATE Deposit 
                    SET Balance = Balance + @DepositAmount - @Penalty,
                        Penalty = @Penalty,
                        LastDepositAmount = @DepositAmount,
                        LastDepositYear = @Year,
                        LastDepositMonth = @Month,
                        LastDepositDate = @DepositDate
                    WHERE UserName = @UserName";

                SqlCommand cmd = db.GetCommand(updateSql);
                cmd.Parameters.AddWithValue("@DepositAmount", depositAmount);
                cmd.Parameters.AddWithValue("@Penalty", penalty);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Month", monthName); // save month name
                cmd.Parameters.AddWithValue("@DepositDate", depositDate);
                cmd.Parameters.AddWithValue("@UserName", userName);

                int rows = db.ExecuteNonQuery(cmd);

                if (rows > 0)
                {
                    MessageBox.Show("Deposit successful.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers();
                    ClearFields(); // Clear all fields after transaction
                }
                else
                {
                    MessageBox.Show("User not found or no update made.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during deposit: " + ex.Message);
            }
        }

        // ================== CLEAR FIELDS ==================
        private void ClearFields()
        {
            UserNameTxtBox.Clear();
            AmountTxtBox.Clear();
            PenaltyTxtBox.Clear();
            YearPicker.Value = DateTime.Now;
            MonthPicker.Value = DateTime.Now;
        }
    }
}
