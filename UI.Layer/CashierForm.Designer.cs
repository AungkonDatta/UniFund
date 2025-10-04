namespace UniFund
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Lbtn = new System.Windows.Forms.Button();
            this.Dbtn = new System.Windows.Forms.Button();
            this.Pbtn = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Location = new System.Drawing.Point(200, 0);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(634, 532);
            this.FormPanel.TabIndex = 3;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MenuPanel.Controls.Add(this.Logoutbtn);
            this.MenuPanel.Controls.Add(this.Lbtn);
            this.MenuPanel.Controls.Add(this.Dbtn);
            this.MenuPanel.Controls.Add(this.Pbtn);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 532);
            this.MenuPanel.TabIndex = 2;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.Location = new System.Drawing.Point(34, 367);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(130, 43);
            this.Logoutbtn.TabIndex = 4;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Lbtn
            // 
            this.Lbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Lbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbtn.Location = new System.Drawing.Point(34, 282);
            this.Lbtn.Name = "Lbtn";
            this.Lbtn.Size = new System.Drawing.Size(130, 43);
            this.Lbtn.TabIndex = 2;
            this.Lbtn.Text = "Loan";
            this.Lbtn.UseVisualStyleBackColor = false;
            this.Lbtn.Click += new System.EventHandler(this.Lbtn_Click);
            // 
            // Dbtn
            // 
            this.Dbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Dbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbtn.Location = new System.Drawing.Point(34, 198);
            this.Dbtn.Name = "Dbtn";
            this.Dbtn.Size = new System.Drawing.Size(130, 43);
            this.Dbtn.TabIndex = 1;
            this.Dbtn.Text = "Deposit";
            this.Dbtn.UseVisualStyleBackColor = false;
            this.Dbtn.Click += new System.EventHandler(this.Dbtn_Click);
            // 
            // Pbtn
            // 
            this.Pbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Pbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pbtn.Location = new System.Drawing.Point(34, 115);
            this.Pbtn.Name = "Pbtn";
            this.Pbtn.Size = new System.Drawing.Size(130, 43);
            this.Pbtn.TabIndex = 0;
            this.Pbtn.Text = "Profile";
            this.Pbtn.UseVisualStyleBackColor = false;
            this.Pbtn.Click += new System.EventHandler(this.Pbtn_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 531);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UniFund - Cashier";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button Lbtn;
        private System.Windows.Forms.Button Dbtn;
        private System.Windows.Forms.Button Pbtn;
    }
}