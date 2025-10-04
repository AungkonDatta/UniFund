namespace UniFund
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Dashbtn = new System.Windows.Forms.Button();
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
            this.FormPanel.TabIndex = 5;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MenuPanel.Controls.Add(this.Logoutbtn);
            this.MenuPanel.Controls.Add(this.Dashbtn);
            this.MenuPanel.Controls.Add(this.Pbtn);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 532);
            this.MenuPanel.TabIndex = 4;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.Location = new System.Drawing.Point(34, 316);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(130, 43);
            this.Logoutbtn.TabIndex = 4;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Dashbtn
            // 
            this.Dashbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Dashbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashbtn.Location = new System.Drawing.Point(34, 233);
            this.Dashbtn.Name = "Dashbtn";
            this.Dashbtn.Size = new System.Drawing.Size(130, 43);
            this.Dashbtn.TabIndex = 1;
            this.Dashbtn.Text = "Dashboard";
            this.Dashbtn.UseVisualStyleBackColor = false;
            this.Dashbtn.Click += new System.EventHandler(this.Dashbtn_Click);
            // 
            // Pbtn
            // 
            this.Pbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Pbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pbtn.Location = new System.Drawing.Point(34, 152);
            this.Pbtn.Name = "Pbtn";
            this.Pbtn.Size = new System.Drawing.Size(130, 43);
            this.Pbtn.TabIndex = 0;
            this.Pbtn.Text = "Profile";
            this.Pbtn.UseVisualStyleBackColor = false;
            this.Pbtn.Click += new System.EventHandler(this.Pbtn_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 531);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UniFund - User";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button Dashbtn;
        private System.Windows.Forms.Button Pbtn;
    }
}