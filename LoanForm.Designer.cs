namespace UniFund
{
    partial class LoanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrintReceiptBtn = new System.Windows.Forms.Button();
            this.InterestTxtBox = new System.Windows.Forms.TextBox();
            this.AmountTxtBox = new System.Windows.Forms.TextBox();
            this.MemberGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LoanBtn = new System.Windows.Forms.Button();
            this.PaidBtn = new System.Windows.Forms.Button();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YearPicker = new System.Windows.Forms.DateTimePicker();
            this.MonthPicker = new System.Windows.Forms.DateTimePicker();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastInterestMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastInterestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintReceiptBtn
            // 
            this.PrintReceiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptBtn.Location = new System.Drawing.Point(486, 198);
            this.PrintReceiptBtn.Name = "PrintReceiptBtn";
            this.PrintReceiptBtn.Size = new System.Drawing.Size(110, 35);
            this.PrintReceiptBtn.TabIndex = 51;
            this.PrintReceiptBtn.Text = "Print Receipt";
            this.PrintReceiptBtn.UseVisualStyleBackColor = true;
            // 
            // InterestTxtBox
            // 
            this.InterestTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InterestTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestTxtBox.Location = new System.Drawing.Point(155, 207);
            this.InterestTxtBox.Name = "InterestTxtBox";
            this.InterestTxtBox.Size = new System.Drawing.Size(225, 26);
            this.InterestTxtBox.TabIndex = 50;
            // 
            // AmountTxtBox
            // 
            this.AmountTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTxtBox.Location = new System.Drawing.Point(155, 172);
            this.AmountTxtBox.Name = "AmountTxtBox";
            this.AmountTxtBox.Size = new System.Drawing.Size(225, 26);
            this.AmountTxtBox.TabIndex = 49;
            // 
            // MemberGridView
            // 
            this.MemberGridView.AllowUserToAddRows = false;
            this.MemberGridView.AllowUserToDeleteRows = false;
            this.MemberGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MemberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.LoanAmount,
            this.LastInterestMonth,
            this.LastInterestDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MemberGridView.Location = new System.Drawing.Point(39, 274);
            this.MemberGridView.Name = "MemberGridView";
            this.MemberGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MemberGridView.Size = new System.Drawing.Size(557, 246);
            this.MemberGridView.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Inerest        :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "LOAN BOOK";
            // 
            // LoanBtn
            // 
            this.LoanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanBtn.Location = new System.Drawing.Point(486, 154);
            this.LoanBtn.Name = "LoanBtn";
            this.LoanBtn.Size = new System.Drawing.Size(110, 35);
            this.LoanBtn.TabIndex = 45;
            this.LoanBtn.Text = "Loan";
            this.LoanBtn.UseVisualStyleBackColor = true;
            // 
            // PaidBtn
            // 
            this.PaidBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidBtn.Location = new System.Drawing.Point(486, 111);
            this.PaidBtn.Name = "PaidBtn";
            this.PaidBtn.Size = new System.Drawing.Size(110, 35);
            this.PaidBtn.TabIndex = 44;
            this.PaidBtn.Text = "Paid";
            this.PaidBtn.UseVisualStyleBackColor = true;
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryBtn.Location = new System.Drawing.Point(486, 67);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(110, 35);
            this.HistoryBtn.TabIndex = 43;
            this.HistoryBtn.Text = "History";
            this.HistoryBtn.UseVisualStyleBackColor = true;
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.UserNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxtBox.Location = new System.Drawing.Point(155, 67);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.ReadOnly = true;
            this.UserNameTxtBox.Size = new System.Drawing.Size(225, 26);
            this.UserNameTxtBox.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Year            :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Month          :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "User Name  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Amount       :";
            // 
            // YearPicker
            // 
            this.YearPicker.CustomFormat = "";
            this.YearPicker.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearPicker.Location = new System.Drawing.Point(155, 102);
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.Size = new System.Drawing.Size(225, 27);
            this.YearPicker.TabIndex = 52;
            // 
            // MonthPicker
            // 
            this.MonthPicker.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthPicker.Location = new System.Drawing.Point(155, 136);
            this.MonthPicker.Name = "MonthPicker";
            this.MonthPicker.Size = new System.Drawing.Size(225, 27);
            this.MonthPicker.TabIndex = 53;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // LoanAmount
            // 
            this.LoanAmount.HeaderText = "Loan";
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.ReadOnly = true;
            // 
            // LastInterestMonth
            // 
            this.LastInterestMonth.HeaderText = "LastIntMonth";
            this.LastInterestMonth.Name = "LastInterestMonth";
            this.LastInterestMonth.ReadOnly = true;
            // 
            // LastInterestDate
            // 
            this.LastInterestDate.HeaderText = "LastIntDate";
            this.LastInterestDate.Name = "LastInterestDate";
            this.LastInterestDate.ReadOnly = true;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(634, 531);
            this.Controls.Add(this.MonthPicker);
            this.Controls.Add(this.PrintReceiptBtn);
            this.Controls.Add(this.InterestTxtBox);
            this.Controls.Add(this.AmountTxtBox);
            this.Controls.Add(this.YearPicker);
            this.Controls.Add(this.MemberGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoanBtn);
            this.Controls.Add(this.PaidBtn);
            this.Controls.Add(this.HistoryBtn);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrintReceiptBtn;
        private System.Windows.Forms.TextBox InterestTxtBox;
        private System.Windows.Forms.TextBox AmountTxtBox;
        private System.Windows.Forms.DataGridView MemberGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LoanBtn;
        private System.Windows.Forms.Button PaidBtn;
        private System.Windows.Forms.Button HistoryBtn;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker YearPicker;
        private System.Windows.Forms.DateTimePicker MonthPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastInterestMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastInterestDate;
    }
}