namespace Project_Library
{
    partial class ctrlLendBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvReaderInfo = new System.Windows.Forms.DataGridView();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.gbReaderInfo = new System.Windows.Forms.GroupBox();
            this.btnReaderSearch = new System.Windows.Forms.Button();
            this.tbReaderSearch = new System.Windows.Forms.TextBox();
            this.rdReaderName = new System.Windows.Forms.RadioButton();
            this.rdReaderCard = new System.Windows.Forms.RadioButton();
            this.gbBookInfo = new System.Windows.Forms.GroupBox();
            this.btnBookInfoSearch = new System.Windows.Forms.Button();
            this.tbBookInfo = new System.Windows.Forms.TextBox();
            this.rdBookName = new System.Windows.Forms.RadioButton();
            this.rdBookId = new System.Windows.Forms.RadioButton();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bgLendBook = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBookCondition = new System.Windows.Forms.ComboBox();
            this.dtpExpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReaderId = new System.Windows.Forms.TextBox();
            this.tbLibrarianId = new System.Windows.Forms.TextBox();
            this.tbBookId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateLendTicket = new System.Windows.Forms.Button();
            this.btnRefreshTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.gbReaderInfo.SuspendLayout();
            this.gbBookInfo.SuspendLayout();
            this.bgLendBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReaderInfo
            // 
            this.dgvReaderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvReaderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaderInfo.Location = new System.Drawing.Point(3, 86);
            this.dgvReaderInfo.Name = "dgvReaderInfo";
            this.dgvReaderInfo.RowTemplate.Height = 25;
            this.dgvReaderInfo.Size = new System.Drawing.Size(347, 570);
            this.dgvReaderInfo.TabIndex = 0;
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Location = new System.Drawing.Point(356, 86);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.RowTemplate.Height = 25;
            this.dgvBookInfo.Size = new System.Drawing.Size(366, 570);
            this.dgvBookInfo.TabIndex = 1;
            // 
            // gbReaderInfo
            // 
            this.gbReaderInfo.Controls.Add(this.btnReaderSearch);
            this.gbReaderInfo.Controls.Add(this.tbReaderSearch);
            this.gbReaderInfo.Controls.Add(this.rdReaderName);
            this.gbReaderInfo.Controls.Add(this.rdReaderCard);
            this.gbReaderInfo.Location = new System.Drawing.Point(3, 3);
            this.gbReaderInfo.Name = "gbReaderInfo";
            this.gbReaderInfo.Size = new System.Drawing.Size(347, 77);
            this.gbReaderInfo.TabIndex = 3;
            this.gbReaderInfo.TabStop = false;
            this.gbReaderInfo.Text = "Reader Info Search";
            // 
            // btnReaderSearch
            // 
            this.btnReaderSearch.Location = new System.Drawing.Point(208, 46);
            this.btnReaderSearch.Name = "btnReaderSearch";
            this.btnReaderSearch.Size = new System.Drawing.Size(75, 23);
            this.btnReaderSearch.TabIndex = 3;
            this.btnReaderSearch.Text = "Search";
            this.btnReaderSearch.UseVisualStyleBackColor = true;
            // 
            // tbReaderSearch
            // 
            this.tbReaderSearch.Location = new System.Drawing.Point(6, 47);
            this.tbReaderSearch.Name = "tbReaderSearch";
            this.tbReaderSearch.Size = new System.Drawing.Size(196, 23);
            this.tbReaderSearch.TabIndex = 2;
            // 
            // rdReaderName
            // 
            this.rdReaderName.AutoSize = true;
            this.rdReaderName.Location = new System.Drawing.Point(106, 22);
            this.rdReaderName.Name = "rdReaderName";
            this.rdReaderName.Size = new System.Drawing.Size(96, 19);
            this.rdReaderName.TabIndex = 1;
            this.rdReaderName.TabStop = true;
            this.rdReaderName.Text = "Reader Name";
            this.rdReaderName.UseVisualStyleBackColor = true;
            // 
            // rdReaderCard
            // 
            this.rdReaderCard.AutoSize = true;
            this.rdReaderCard.Location = new System.Drawing.Point(6, 22);
            this.rdReaderCard.Name = "rdReaderCard";
            this.rdReaderCard.Size = new System.Drawing.Size(89, 19);
            this.rdReaderCard.TabIndex = 0;
            this.rdReaderCard.TabStop = true;
            this.rdReaderCard.Text = "Reader Card";
            this.rdReaderCard.UseVisualStyleBackColor = true;
            // 
            // gbBookInfo
            // 
            this.gbBookInfo.Controls.Add(this.btnBookInfoSearch);
            this.gbBookInfo.Controls.Add(this.tbBookInfo);
            this.gbBookInfo.Controls.Add(this.rdBookName);
            this.gbBookInfo.Controls.Add(this.rdBookId);
            this.gbBookInfo.Location = new System.Drawing.Point(356, 3);
            this.gbBookInfo.Name = "gbBookInfo";
            this.gbBookInfo.Size = new System.Drawing.Size(366, 77);
            this.gbBookInfo.TabIndex = 4;
            this.gbBookInfo.TabStop = false;
            this.gbBookInfo.Text = "Book Info Search";
            // 
            // btnBookInfoSearch
            // 
            this.btnBookInfoSearch.Location = new System.Drawing.Point(199, 46);
            this.btnBookInfoSearch.Name = "btnBookInfoSearch";
            this.btnBookInfoSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBookInfoSearch.TabIndex = 3;
            this.btnBookInfoSearch.Text = "Search";
            this.btnBookInfoSearch.UseVisualStyleBackColor = true;
            // 
            // tbBookInfo
            // 
            this.tbBookInfo.Location = new System.Drawing.Point(6, 48);
            this.tbBookInfo.Name = "tbBookInfo";
            this.tbBookInfo.Size = new System.Drawing.Size(187, 23);
            this.tbBookInfo.TabIndex = 2;
            // 
            // rdBookName
            // 
            this.rdBookName.AutoSize = true;
            this.rdBookName.Location = new System.Drawing.Point(106, 22);
            this.rdBookName.Name = "rdBookName";
            this.rdBookName.Size = new System.Drawing.Size(87, 19);
            this.rdBookName.TabIndex = 1;
            this.rdBookName.TabStop = true;
            this.rdBookName.Text = "Book Name";
            this.rdBookName.UseVisualStyleBackColor = true;
            // 
            // rdBookId
            // 
            this.rdBookId.AutoSize = true;
            this.rdBookId.Location = new System.Drawing.Point(6, 22);
            this.rdBookId.Name = "rdBookId";
            this.rdBookId.Size = new System.Drawing.Size(66, 19);
            this.rdBookId.TabIndex = 0;
            this.rdBookId.TabStop = true;
            this.rdBookId.Text = "Book ID";
            this.rdBookId.UseVisualStyleBackColor = true;
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTicket.Location = new System.Drawing.Point(-4681, 215);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(89, 23);
            this.btnCreateTicket.TabIndex = 5;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(-4502, 215);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // bgLendBook
            // 
            this.bgLendBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bgLendBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bgLendBook.Controls.Add(this.label6);
            this.bgLendBook.Controls.Add(this.label5);
            this.bgLendBook.Controls.Add(this.cbBookCondition);
            this.bgLendBook.Controls.Add(this.dtpExpReturnDate);
            this.bgLendBook.Controls.Add(this.label3);
            this.bgLendBook.Controls.Add(this.tbReaderId);
            this.bgLendBook.Controls.Add(this.tbLibrarianId);
            this.bgLendBook.Controls.Add(this.tbBookId);
            this.bgLendBook.Controls.Add(this.label2);
            this.bgLendBook.Controls.Add(this.label1);
            this.bgLendBook.Location = new System.Drawing.Point(728, 3);
            this.bgLendBook.Name = "bgLendBook";
            this.bgLendBook.Size = new System.Drawing.Size(422, 161);
            this.bgLendBook.TabIndex = 8;
            this.bgLendBook.TabStop = false;
            this.bgLendBook.Text = "Lend Ticket Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Book Condition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expected Return Date";
            // 
            // cbBookCondition
            // 
            this.cbBookCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBookCondition.FormattingEnabled = true;
            this.cbBookCondition.Location = new System.Drawing.Point(132, 132);
            this.cbBookCondition.Name = "cbBookCondition";
            this.cbBookCondition.Size = new System.Drawing.Size(290, 23);
            this.cbBookCondition.TabIndex = 8;
            // 
            // dtpExpReturnDate
            // 
            this.dtpExpReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpReturnDate.Location = new System.Drawing.Point(132, 103);
            this.dtpExpReturnDate.Name = "dtpExpReturnDate";
            this.dtpExpReturnDate.Size = new System.Drawing.Size(284, 23);
            this.dtpExpReturnDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reader ID";
            // 
            // tbReaderId
            // 
            this.tbReaderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReaderId.Location = new System.Drawing.Point(132, 74);
            this.tbReaderId.Name = "tbReaderId";
            this.tbReaderId.Size = new System.Drawing.Size(284, 23);
            this.tbReaderId.TabIndex = 4;
            // 
            // tbLibrarianId
            // 
            this.tbLibrarianId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLibrarianId.Location = new System.Drawing.Point(132, 45);
            this.tbLibrarianId.Name = "tbLibrarianId";
            this.tbLibrarianId.ReadOnly = true;
            this.tbLibrarianId.Size = new System.Drawing.Size(284, 23);
            this.tbLibrarianId.TabIndex = 3;
            // 
            // tbBookId
            // 
            this.tbBookId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBookId.Location = new System.Drawing.Point(132, 16);
            this.tbBookId.Name = "tbBookId";
            this.tbBookId.Size = new System.Drawing.Size(284, 23);
            this.tbBookId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Librarian ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // btnCreateLendTicket
            // 
            this.btnCreateLendTicket.Location = new System.Drawing.Point(768, 170);
            this.btnCreateLendTicket.Name = "btnCreateLendTicket";
            this.btnCreateLendTicket.Size = new System.Drawing.Size(86, 23);
            this.btnCreateLendTicket.TabIndex = 9;
            this.btnCreateLendTicket.Text = "Create Ticket";
            this.btnCreateLendTicket.UseVisualStyleBackColor = true;
            // 
            // btnRefreshTicket
            // 
            this.btnRefreshTicket.Location = new System.Drawing.Point(944, 170);
            this.btnRefreshTicket.Name = "btnRefreshTicket";
            this.btnRefreshTicket.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshTicket.TabIndex = 10;
            this.btnRefreshTicket.Text = "Refresh";
            this.btnRefreshTicket.UseVisualStyleBackColor = true;
            // 
            // ctrlLendBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnRefreshTicket);
            this.Controls.Add(this.btnCreateLendTicket);
            this.Controls.Add(this.bgLendBook);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.gbBookInfo);
            this.Controls.Add(this.gbReaderInfo);
            this.Controls.Add(this.dgvBookInfo);
            this.Controls.Add(this.dgvReaderInfo);
            this.Name = "ctrlLendBook";
            this.Size = new System.Drawing.Size(1158, 659);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.gbReaderInfo.ResumeLayout(false);
            this.gbReaderInfo.PerformLayout();
            this.gbBookInfo.ResumeLayout(false);
            this.gbBookInfo.PerformLayout();
            this.bgLendBook.ResumeLayout(false);
            this.bgLendBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvReaderInfo;
        private DataGridView dgvBookInfo;
        private GroupBox gbReaderInfo;
        private Button btnReaderSearch;
        private TextBox tbReaderSearch;
        private RadioButton rdReaderName;
        private RadioButton rdReaderCard;
        private GroupBox gbBookInfo;
        private Button btnBookInfoSearch;
        private TextBox tbBookInfo;
        private RadioButton rdBookName;
        private RadioButton rdBookId;
        private Button btnCreateTicket;
        private Button btnRefresh;
        private GroupBox bgLendBook;
        private Label label6;
        private Label label5;
        private ComboBox cbBookCondition;
        private DateTimePicker dtpExpReturnDate;
        private Label label3;
        private TextBox tbReaderId;
        private TextBox tbLibrarianId;
        private TextBox tbBookId;
        private Label label2;
        private Label label1;
        private Button btnCreateLendTicket;
        private Button btnRefreshTicket;
    }
}
