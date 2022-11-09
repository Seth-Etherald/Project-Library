namespace Project_Library
{
    partial class FrmReturnBook
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
            this.tbTicketId = new System.Windows.Forms.TextBox();
            this.tbReaderId = new System.Windows.Forms.TextBox();
            this.tbReaderName = new System.Windows.Forms.TextBox();
            this.tbBookId = new System.Windows.Forms.TextBox();
            this.dtpExpectedReturnDate = new System.Windows.Forms.DateTimePicker();
            this.tbLibrarianId = new System.Windows.Forms.TextBox();
            this.cbReturnCondition = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudOverdue = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverdue)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTicketId
            // 
            this.tbTicketId.Location = new System.Drawing.Point(134, 27);
            this.tbTicketId.Name = "tbTicketId";
            this.tbTicketId.ReadOnly = true;
            this.tbTicketId.Size = new System.Drawing.Size(100, 23);
            this.tbTicketId.TabIndex = 0;
            // 
            // tbReaderId
            // 
            this.tbReaderId.Location = new System.Drawing.Point(134, 72);
            this.tbReaderId.Name = "tbReaderId";
            this.tbReaderId.ReadOnly = true;
            this.tbReaderId.Size = new System.Drawing.Size(100, 23);
            this.tbReaderId.TabIndex = 1;
            // 
            // tbReaderName
            // 
            this.tbReaderName.Location = new System.Drawing.Point(495, 22);
            this.tbReaderName.Name = "tbReaderName";
            this.tbReaderName.ReadOnly = true;
            this.tbReaderName.Size = new System.Drawing.Size(172, 23);
            this.tbReaderName.TabIndex = 2;
            // 
            // tbBookId
            // 
            this.tbBookId.Location = new System.Drawing.Point(495, 67);
            this.tbBookId.Name = "tbBookId";
            this.tbBookId.ReadOnly = true;
            this.tbBookId.Size = new System.Drawing.Size(100, 23);
            this.tbBookId.TabIndex = 3;
            // 
            // dtpExpectedReturnDate
            // 
            this.dtpExpectedReturnDate.Enabled = false;
            this.dtpExpectedReturnDate.Location = new System.Drawing.Point(134, 162);
            this.dtpExpectedReturnDate.Name = "dtpExpectedReturnDate";
            this.dtpExpectedReturnDate.Size = new System.Drawing.Size(200, 23);
            this.dtpExpectedReturnDate.TabIndex = 4;
            // 
            // tbLibrarianId
            // 
            this.tbLibrarianId.Location = new System.Drawing.Point(134, 115);
            this.tbLibrarianId.Name = "tbLibrarianId";
            this.tbLibrarianId.ReadOnly = true;
            this.tbLibrarianId.Size = new System.Drawing.Size(100, 23);
            this.tbLibrarianId.TabIndex = 5;
            // 
            // cbReturnCondition
            // 
            this.cbReturnCondition.FormattingEnabled = true;
            this.cbReturnCondition.Location = new System.Drawing.Point(495, 115);
            this.cbReturnCondition.Name = "cbReturnCondition";
            this.cbReturnCondition.Size = new System.Drawing.Size(121, 23);
            this.cbReturnCondition.TabIndex = 6;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(271, 228);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Confirm";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ticket Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reader Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Librarian Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Reader Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Expected return date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Book Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Return Condition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Overdue by";
            // 
            // nudOverdue
            // 
            this.nudOverdue.Location = new System.Drawing.Point(495, 162);
            this.nudOverdue.Name = "nudOverdue";
            this.nudOverdue.ReadOnly = true;
            this.nudOverdue.Size = new System.Drawing.Size(120, 23);
            this.nudOverdue.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(621, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "day(s)";
            // 
            // FrmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 265);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudOverdue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cbReturnCondition);
            this.Controls.Add(this.tbLibrarianId);
            this.Controls.Add(this.dtpExpectedReturnDate);
            this.Controls.Add(this.tbBookId);
            this.Controls.Add(this.tbReaderName);
            this.Controls.Add(this.tbReaderId);
            this.Controls.Add(this.tbTicketId);
            this.Name = "FrmReturnBook";
            this.Text = "Return Book";
            ((System.ComponentModel.ISupportInitialize)(this.nudOverdue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTicketId;
        private TextBox tbReaderId;
        private TextBox tbReaderName;
        private TextBox tbBookId;
        private DateTimePicker dtpExpectedReturnDate;
        private TextBox tbLibrarianId;
        private ComboBox cbReturnCondition;
        private Button btnReturn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown nudOverdue;
        private Label label9;
    }
}