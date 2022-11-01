namespace Project_Library
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.cbShowPW = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbToday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(215, 69);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(267, 23);
            this.tbAccount.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(215, 125);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(267, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAccount.Location = new System.Drawing.Point(104, 72);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(59, 19);
            this.lbAccount.TabIndex = 2;
            this.lbAccount.Text = "Account";
            this.lbAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(104, 128);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 19);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbShowPW
            // 
            this.cbShowPW.AutoSize = true;
            this.cbShowPW.Location = new System.Drawing.Point(215, 165);
            this.cbShowPW.Name = "cbShowPW";
            this.cbShowPW.Size = new System.Drawing.Size(108, 19);
            this.cbShowPW.TabIndex = 4;
            this.cbShowPW.Text = "Show Password";
            this.cbShowPW.UseVisualStyleBackColor = true;
            this.cbShowPW.CheckedChanged += new System.EventHandler(this.CbShowPW_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(298, 208);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lbToday
            // 
            this.lbToday.AutoSize = true;
            this.lbToday.Location = new System.Drawing.Point(12, 261);
            this.lbToday.Name = "lbToday";
            this.lbToday.Size = new System.Drawing.Size(0, 15);
            this.lbToday.TabIndex = 8;
            this.lbToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 285);
            this.Controls.Add(this.lbToday);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbShowPW);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbAccount;
        private TextBox tbPassword;
        private Label lbAccount;
        private Label lbPassword;
        private CheckBox cbShowPW;
        private Button btnLogin;
        private Label lbToday;
    }
}