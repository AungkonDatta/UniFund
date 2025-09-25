using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace UniFund
{
    public partial class LoanForm : Form
    {
        private DataAccess db;

        public LoanForm()
        {
            InitializeComponent();
            db = new DataAccess();

            LoanBtn.Click += LoanBtn_Click;
            PaidBtn.Click += PaidBtn_Click;
            MemberGridView.CellClick += MemberGridView_CellClick;
            this.Load += LoanForm_Load;

            MemberGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MemberGridView.MultiSelect = false;
        }

        // ================== FORM LOAD ==================
        private void LoanForm_Load(object sender, EventArgs e)
        {
            YearPicker.Format = DateTimePickerFormat.Custom;
            YearPicker.CustomFormat = "yyyy";
            YearPicker.ShowUpDown = true;

            MonthPicker.Format = DateTimePickerFormat.Custom;
            MonthPicker.CustomFormat = "MMMM";
            MonthPicker.ShowUpDown = true;

            SyncMembersToLoan();
            LoadLoans();
        }

        // ================== SYNC MEMBERS ==================
        private void SyncMembersToLoan()
        {
            try
            {
                string sql = @"
                    INSERT INTO Loan (UserName, LoanAmount, Interest)
                    SELECT d.UserName, 0, 0
                    FROM Deposit d
                    WHERE NOT EXISTS (SELECT 1 FROM Loan l WHERE l.UserName = d.UserName)";
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error syncing members to Loan table: " + ex.Message);
            }
        }

        // ================== LOAD GRID ==================
        private void LoadLoans()
        {
            try
            {
                string query = @"
                    SELECT 
                        UserName, 
                        LoanAmount, 
                        LastInterestMonth, 
                        LastInterestDate
                    FROM Loan";

                DataTable dt = db.Execute(query);

                MemberGridView.AutoGenerateColumns = false;
                MemberGridView.DataSource = dt;

                // Show only required columns
                MemberGridView.Columns["UserName"].DataPropertyName = "UserName";
                MemberGridView.Columns["LoanAmount"].DataPropertyName = "LoanAmount";
                MemberGridView.Columns["LastInterestMonth"].DataPropertyName = "LastInterestMonth";
                MemberGridView.Columns["LastInterestDate"].DataPropertyName = "LastInterestDate";

                MemberGridView.Columns["LastInterestDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";

                MemberGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading loans: " + ex.Message);
            }
        }

        // ================== GRID CLICK ==================
        private void MemberGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= MemberGridView.Rows.Count) return;

            DataGridViewRow row = MemberGridView.Rows[e.RowIndex];
            if (row.Cells["UserName"].Value != null)
            {
                UserNameTxtBox.Text = row.Cells["UserName"].Value.ToString();
            }

            AmountTxtBox.Clear();
            InterestTxtBox.Clear();
            YearPicker.Value = DateTime.Now;
            MonthPicker.Value = DateTime.Now;
        }

        // ================== LOAN BUTTON ==================
        private void LoanBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxtBox.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please select a member first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasLoanAmount = decimal.TryParse(AmountTxtBox.Text, out decimal loanAmount) && loanAmount > 0;
            bool hasInterest = decimal.TryParse(InterestTxtBox.Text, out decimal interest) && interest > 0;

            if (!hasLoanAmount && !hasInterest)
            {
                MessageBox.Show("Enter loan amount or interest.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check total deposit balance if loan is requested
            if (hasLoanAmount)
            {
                string totalBalanceSql = "SELECT SUM(Balance) AS TotalBalance FROM Deposit";
                DataTable dtTotal = db.Execute(totalBalanceSql);
                decimal totalBalance = dtTotal.Rows.Count > 0 ? Convert.ToDecimal(dtTotal.Rows[0]["TotalBalance"]) : 0;

                if (totalBalance < loanAmount)
                {
                    MessageBox.Show("Insufficient total deposits. Loan cannot be issued.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int year = YearPicker.Value.Year;
            string monthName = MonthPicker.Value.ToString("MMMM");
            DateTime now = DateTime.Now;

            try
            {
                // Update Loan table
                string sql = @"
                    IF EXISTS (SELECT 1 FROM Loan WHERE UserName=@UserName)
                    BEGIN
                        UPDATE Loan
                        SET LoanAmount = LoanAmount + @LoanAmount,
                            LastLoanYear = CASE WHEN @LoanAmount>0 THEN @Year ELSE LastLoanYear END,
                            LastLoanMonth = CASE WHEN @LoanAmount>0 THEN @Month ELSE LastLoanMonth END,
                            LastLoanDate = CASE WHEN @LoanAmount>0 THEN @Now ELSE LastLoanDate END,
                            Interest = Interest + @Interest,
                            LastInterestYear = CASE WHEN @Interest>0 THEN @Year ELSE LastInterestYear END,
                            LastInterestMonth = CASE WHEN @Interest>0 THEN @Month ELSE LastInterestMonth END,
                            LastInterestDate = CASE WHEN @Interest>0 THEN @Now ELSE LastInterestDate END
                        WHERE UserName=@UserName
                    END
                    ELSE
                    BEGIN
                        INSERT INTO Loan (UserName, LoanAmount, Interest, LastLoanYear, LastLoanMonth, LastLoanDate,
                                          LastInterestYear, LastInterestMonth, LastInterestDate)
                        VALUES (@UserName, @LoanAmount, @Interest,
                                CASE WHEN @LoanAmount>0 THEN @Year ELSE NULL END,
                                CASE WHEN @LoanAmount>0 THEN @Month ELSE NULL END,
                                CASE WHEN @LoanAmount>0 THEN @Now ELSE NULL END,
                                CASE WHEN @Interest>0 THEN @Year ELSE NULL END,
                                CASE WHEN @Interest>0 THEN @Month ELSE NULL END,
                                CASE WHEN @Interest>0 THEN @Now ELSE NULL END)
                    END";

                SqlCommand cmd = db.GetCommand(sql);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@LoanAmount", hasLoanAmount ? loanAmount : 0);
                cmd.Parameters.AddWithValue("@Interest", hasInterest ? interest : 0);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Month", monthName);
                cmd.Parameters.AddWithValue("@Now", now);

                db.ExecuteNonQuery(cmd);

                // Distribute interest to all members if interest added
                if (hasInterest)
                {
                    DistributeInterestToAllMembers(interest);
                }

                MessageBox.Show("Loan/Interest recorded successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLoans();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during loan operation: " + ex.Message);
            }
        }

        // ================== PAID BUTTON ==================
        private void PaidBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxtBox.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please select a member first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasLoanPayment = decimal.TryParse(AmountTxtBox.Text, out decimal loanPaid) && loanPaid > 0;
            bool hasInterestPayment = decimal.TryParse(InterestTxtBox.Text, out decimal interestPaid) && interestPaid > 0;

            if (!hasLoanPayment && !hasInterestPayment)
            {
                MessageBox.Show("Enter either loan amount or interest to pay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = "SELECT LoanAmount, Interest FROM Loan WHERE UserName=@UserName";
                SqlCommand cmd = db.GetCommand(sql);
                cmd.Parameters.AddWithValue("@UserName", userName);
                DataTable dt = db.Execute(cmd);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No active loan found for this member.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                decimal currentLoan = Convert.ToDecimal(dt.Rows[0]["LoanAmount"]);
                decimal currentInterest = Convert.ToDecimal(dt.Rows[0]["Interest"]);

                decimal newLoan = hasLoanPayment ? Math.Max(currentLoan - loanPaid, 0) : currentLoan;
                decimal newInterest = hasInterestPayment ? currentInterest + interestPaid : currentInterest; // **Add interest**

                string monthName = DateTime.Now.ToString("MMMM");
                int year = DateTime.Now.Year;
                DateTime now = DateTime.Now;

                // Update Loan table
                string updateSql = @"
                    UPDATE Loan
                    SET 
                        LoanAmount = @NewLoan,
                        LastLoanYear = CASE WHEN @LoanPaid>0 THEN @Year ELSE LastLoanYear END,
                        LastLoanMonth = CASE WHEN @LoanPaid>0 THEN @Month ELSE LastLoanMonth END,
                        LastLoanDate = CASE WHEN @LoanPaid>0 THEN @Now ELSE LastLoanDate END,
                        Interest = @NewInterest,
                        LastInterestYear = CASE WHEN @InterestPaid>0 THEN @Year ELSE LastInterestYear END,
                        LastInterestMonth = CASE WHEN @InterestPaid>0 THEN @Month ELSE LastInterestMonth END,
                        LastInterestDate = CASE WHEN @InterestPaid>0 THEN @Now ELSE LastInterestDate END
                    WHERE UserName=@UserName";

                SqlCommand updateCmd = db.GetCommand(updateSql);
                updateCmd.Parameters.AddWithValue("@NewLoan", newLoan);
                updateCmd.Parameters.AddWithValue("@NewInterest", newInterest);
                updateCmd.Parameters.AddWithValue("@LoanPaid", hasLoanPayment ? 1 : 0);
                updateCmd.Parameters.AddWithValue("@InterestPaid", hasInterestPayment ? 1 : 0);
                updateCmd.Parameters.AddWithValue("@Year", year);
                updateCmd.Parameters.AddWithValue("@Month", monthName);
                updateCmd.Parameters.AddWithValue("@Now", now);
                updateCmd.Parameters.AddWithValue("@UserName", userName);

                db.ExecuteNonQuery(updateCmd);

                // Distribute interest to all members if interest paid
                if (hasInterestPayment)
                {
                    DistributeInterestToAllMembers(interestPaid);
                }

                MessageBox.Show("Payment successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLoans();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during payment: " + ex.Message);
            }
        }

        // ================== DISTRIBUTE INTEREST ==================
        private void DistributeInterestToAllMembers(decimal interestAmount)
        {
            string countSql = "SELECT COUNT(*) AS Total FROM Loan";
            DataTable dtCount = db.Execute(countSql);
            int memberCount = dtCount.Rows.Count > 0 ? Convert.ToInt32(dtCount.Rows[0]["Total"]) : 0;

            if (memberCount > 0)
            {
                decimal addition = interestAmount / memberCount;
                string updateDepositSql = "UPDATE Deposit SET Balance = Balance + @Addition";
                SqlCommand updateDepositCmd = db.GetCommand(updateDepositSql);
                updateDepositCmd.Parameters.AddWithValue("@Addition", addition);
                db.ExecuteNonQuery(updateDepositCmd);
            }
        }

        // ================== CLEAR FIELDS ==================
        private void ClearFields()
        {
            UserNameTxtBox.Clear();
            AmountTxtBox.Clear();
            InterestTxtBox.Clear();
            YearPicker.Value = DateTime.Now;
            MonthPicker.Value = DateTime.Now;
        }
    }
}
