namespace Messenger
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rtxtUserSetting = new System.Windows.Forms.RichTextBox();
            this.chbSavePassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserName.Location = new System.Drawing.Point(60, 62);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.Size = new System.Drawing.Size(161, 21);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydownLogin);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.Location = new System.Drawing.Point(60, 112);
            this.txtPassword.MaxLength = 35;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(160, 21);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydownLogin);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbPassword.Location = new System.Drawing.Point(163, 96);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPassword.Size = new System.Drawing.Size(59, 13);
            this.lbPassword.TabIndex = 11;
            this.lbPassword.Text = "کلمه عبور :";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbUserName.Location = new System.Drawing.Point(163, 46);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbUserName.Size = new System.Drawing.Size(60, 13);
            this.lbUserName.TabIndex = 10;
            this.lbUserName.Text = "نام کاربری :";
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(101, 180);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(80, 37);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "ورود";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rtxtUserSetting
            // 
            this.rtxtUserSetting.Location = new System.Drawing.Point(250, 232);
            this.rtxtUserSetting.Name = "rtxtUserSetting";
            this.rtxtUserSetting.Size = new System.Drawing.Size(22, 18);
            this.rtxtUserSetting.TabIndex = 12;
            this.rtxtUserSetting.Text = "";
            // 
            // chbSavePassword
            // 
            this.chbSavePassword.AutoSize = true;
            this.chbSavePassword.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chbSavePassword.Location = new System.Drawing.Point(93, 139);
            this.chbSavePassword.Name = "chbSavePassword";
            this.chbSavePassword.Size = new System.Drawing.Size(124, 17);
            this.chbSavePassword.TabIndex = 13;
            this.chbSavePassword.Text = "کلمه عبور ذخیره شود";
            this.chbSavePassword.UseVisualStyleBackColor = true;
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chbSavePassword);
            this.Controls.Add(this.rtxtUserSetting);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.LoginUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RichTextBox rtxtUserSetting;
        private System.Windows.Forms.CheckBox chbSavePassword;
    }
}