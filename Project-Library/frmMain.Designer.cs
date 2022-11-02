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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGreeting
            // 
            this.lbGreeting.AutoSize = true;
            this.lbGreeting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGreeting.Location = new System.Drawing.Point(12, 25);
            this.lbGreeting.Name = "lbGreeting";
            this.lbGreeting.Size = new System.Drawing.Size(114, 28);
            this.lbGreeting.TabIndex = 0;
            this.lbGreeting.Text = "Hello";
            this.lbGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(240, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 549);
            this.panel1.TabIndex = 1;
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTitle.Location = new System.Drawing.Point(12, 84);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(222, 77);
            this.btnTitle.TabIndex = 2;
            this.btnTitle.Text = "Manage Title";
            this.btnTitle.UseVisualStyleBackColor = false;
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
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1281, 645);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbGreeting);
            this.Name = "FrmMain";
            this.Text = "Library Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbGreeting;
        private Panel panel1;
        private Button btnTitle;
        private Button btnReader;
        private Button btnLend;
        private Button btnReturn;
        private Button btnAccount;
    }
}