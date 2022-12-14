namespace Project_Library
{
    partial class FrmMain
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
            this.lbGreeting = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGreeting
            // 
            this.lbGreeting.AutoSize = true;
            this.lbGreeting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGreeting.Location = new System.Drawing.Point(12, 25);
            this.lbGreeting.Name = "lbGreeting";
            this.lbGreeting.Size = new System.Drawing.Size(58, 28);
            this.lbGreeting.TabIndex = 0;
            this.lbGreeting.Text = "Hello";
            this.lbGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(240, 84);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1029, 549);
            this.pnMain.TabIndex = 1;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Transparent;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBook.Location = new System.Drawing.Point(12, 84);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(222, 77);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Manage Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // btnReader
            // 
            this.btnReader.BackColor = System.Drawing.Color.Transparent;
            this.btnReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReader.Location = new System.Drawing.Point(12, 167);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(222, 77);
            this.btnReader.TabIndex = 3;
            this.btnReader.Text = "Manage Reader";
            this.btnReader.UseVisualStyleBackColor = false;
            this.btnReader.Click += new System.EventHandler(this.BtnReader_Click);
            // 
            // btnLend
            // 
            this.btnLend.BackColor = System.Drawing.Color.Transparent;
            this.btnLend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLend.Location = new System.Drawing.Point(12, 250);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(222, 77);
            this.btnLend.TabIndex = 4;
            this.btnLend.Text = "Manage Lend Book";
            this.btnLend.UseVisualStyleBackColor = false;
            this.btnLend.Click += new System.EventHandler(this.BtnLend_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(12, 333);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(222, 77);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Manage Return Book";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.Location = new System.Drawing.Point(12, 416);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(222, 77);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Manage Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Visible = false;
            this.btnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Location = new System.Drawing.Point(12, 578);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 55);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1281, 645);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.lbGreeting);
            this.Name = "FrmMain";
            this.Text = "Library Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbGreeting;
        private Panel pnMain;
        private Button btnBook;
        private Button btnReader;
        private Button btnLend;
        private Button btnReturn;
        private Button btnAccount;
        private Button btnLogout;
    }
}