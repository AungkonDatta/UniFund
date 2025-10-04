namespace UniFund
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UniFundLoginLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniFund.Properties.Resources.UniFund_Profile;
            this.pictureBox1.Location = new System.Drawing.Point(0, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UniFundLoginLabel
            // 
            this.UniFundLoginLabel.AutoSize = true;
            this.UniFundLoginLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniFundLoginLabel.Location = new System.Drawing.Point(535, 139);
            this.UniFundLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UniFundLoginLabel.Name = "UniFundLoginLabel";
            this.UniFundLoginLabel.Size = new System.Drawing.Size(211, 32);
            this.UniFundLoginLabel.TabIndex = 1;
            this.UniFundLoginLabel.Text = "UniFund Login";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(495, 221);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(108, 23);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "USER NAME :";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(495, 268);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(107, 23);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "PASSWORD :";
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTxtBox.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxtBox.Location = new System.Drawing.Point(600, 218);
            this.UserNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(177, 29);
            this.UserNameTxtBox.TabIndex = 4;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.Location = new System.Drawing.Point(600, 265);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(177, 29);
            this.PasswordTxtBox.TabIndex = 5;
            this.PasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(599, 331);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(82, 36);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 531);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UniFundLoginLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniFund - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UniFundLoginLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button LoginButton;
    }
}

