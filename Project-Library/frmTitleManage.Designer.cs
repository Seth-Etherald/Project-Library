namespace Project_Library
{
    partial class FrmTitleManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.nudPage = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbTitleId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of pages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publisher";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(152, 103);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(215, 23);
            this.tbTitle.TabIndex = 4;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(152, 161);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(215, 23);
            this.cbAuthor.TabIndex = 6;
            // 
            // cbPublisher
            // 
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(152, 190);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(215, 23);
            this.cbPublisher.TabIndex = 7;
            // 
            // nudPage
            // 
            this.nudPage.Location = new System.Drawing.Point(152, 132);
            this.nudPage.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});

            this.nudPage.Name = "nudPage";
            this.nudPage.Size = new System.Drawing.Size(215, 23);
            this.nudPage.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(161, 238);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Placeholder";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // tbTitleId
            // 
            this.tbTitleId.Location = new System.Drawing.Point(152, 37);
            this.tbTitleId.Name = "tbTitleId";
            this.tbTitleId.Size = new System.Drawing.Size(100, 23);
            this.tbTitleId.TabIndex = 10;
            this.tbTitleId.Visible = false;
            // 
            // FrmTitleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 339);
            this.Controls.Add(this.tbTitleId);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.nudPage);
            this.Controls.Add(this.cbPublisher);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTitleManage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTitleManage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbTitle;
        private ComboBox cbAuthor;
        private ComboBox cbPublisher;
        private NumericUpDown nudPage;
        private Button btnSubmit;
        private TextBox tbTitleId;
    }
}