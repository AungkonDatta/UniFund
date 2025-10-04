namespace UniFund
{
    partial class DepositForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MemberGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDepositMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDepositDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountTxtBox = new System.Windows.Forms.TextBox();
            this.PenaltyTxtBox = new System.Windows.Forms.TextBox();
            this.PrintReceiptBtn = new System.Windows.Forms.Button();
            this.YearPicker = new System.Windows.Forms.DateTimePicker();
            this.MonthPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Month          :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year            :";
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
            this.UserNameTxtBox.TabIndex = 5;
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryBtn.Location = new System.Drawing.Point(486, 67);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(110, 35);
            this.HistoryBtn.TabIndex = 6;
            this.HistoryBtn.Text = "History";
            this.HistoryBtn.UseVisualStyleBackColor = true;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(486, 111);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(110, 35);
            this.RefreshBtn.TabIndex = 7;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // DepositBtn
            // 
            this.DepositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBtn.Location = new System.Drawing.Point(486, 154);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(110, 35);
            this.DepositBtn.TabIndex = 8;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "DEPOSIT BOOK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Penalty        :";
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
            this.Balance,
            this.LastDepositMonth,
            this.LastDepositDate});
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
            this.MemberGridView.TabIndex = 32;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // LastDepositMonth
            // 
            this.LastDepositMonth.HeaderText = "LastDepMonth";
            this.LastDepositMonth.Name = "LastDepositMonth";
            this.LastDepositMonth.ReadOnly = true;
            // 
            // LastDepositDate
            // 
            this.LastDepositDate.HeaderText = "LastDepDate";
            this.LastDepositDate.Name = "LastDepositDate";
            this.LastDepositDate.ReadOnly = true;
            // 
            // AmountTxtBox
            // 
            this.AmountTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTxtBox.Location = new System.Drawing.Point(155, 172);
            this.AmountTxtBox.Name = "AmountTxtBox";
            this.AmountTxtBox.Size = new System.Drawing.Size(225, 26);
            this.AmountTxtBox.TabIndex = 33;
            // 
            // PenaltyTxtBox
            // 
            this.PenaltyTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PenaltyTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenaltyTxtBox.Location = new System.Drawing.Point(155, 207);
            this.PenaltyTxtBox.Name = "PenaltyTxtBox";
            this.PenaltyTxtBox.Size = new System.Drawing.Size(225, 26);
            this.PenaltyTxtBox.TabIndex = 34;
            // 
            // PrintReceiptBtn
            // 
            this.PrintReceiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptBtn.Location = new System.Drawing.Point(486, 198);
            this.PrintReceiptBtn.Name = "PrintReceiptBtn";
            this.PrintReceiptBtn.Size = new System.Drawing.Size(110, 35);
            this.PrintReceiptBtn.TabIndex = 35;
            this.PrintReceiptBtn.Text = "Print Receipt";
            this.PrintReceiptBtn.UseVisualStyleBackColor = true;
            // 
            // YearPicker
            // 
            this.YearPicker.CustomFormat = "";
            this.YearPicker.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearPicker.Location = new System.Drawing.Point(155, 102);
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.Size = new System.Drawing.Size(225, 27);
            this.YearPicker.TabIndex = 36;
            // 
            // MonthPicker
            // 
            this.MonthPicker.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthPicker.Location = new System.Drawing.Point(155, 136);
            this.MonthPicker.Name = "MonthPicker";
            this.MonthPicker.Size = new System.Drawing.Size(225, 27);
            this.MonthPicker.TabIndex = 37;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(634, 531);
            this.Controls.Add(this.MonthPicker);
            this.Controls.Add(this.YearPicker);
            this.Controls.Add(this.PrintReceiptBtn);
            this.Controls.Add(this.PenaltyTxtBox);
            this.Controls.Add(this.AmountTxtBox);
            this.Controls.Add(this.MemberGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.HistoryBtn);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepositForm";
            this.Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.Button HistoryBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView MemberGridView;
        private System.Windows.Forms.TextBox AmountTxtBox;
        private System.Windows.Forms.TextBox PenaltyTxtBox;
        private System.Windows.Forms.Button PrintReceiptBtn;
        private System.Windows.Forms.DateTimePicker YearPicker;
        private System.Windows.Forms.DateTimePicker MonthPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDepositMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDepositDate;
    }
}