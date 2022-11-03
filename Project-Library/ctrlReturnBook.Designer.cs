namespace Project_Library
{
    partial class ctrlReturnBook
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
            this.dgvLendDetail = new System.Windows.Forms.DataGridView();
            this.gbLendBookSearch = new System.Windows.Forms.GroupBox();
            this.rbReaderName = new System.Windows.Forms.RadioButton();
            this.rbLendId = new System.Windows.Forms.RadioButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbReturnBook = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReaderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLendTicketId = new System.Windows.Forms.TextBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLendDetail)).BeginInit();
            this.gbLendBookSearch.SuspendLayout();
            this.gbReturnBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLendDetail
            // 
            this.dgvLendDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLendDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLendDetail.Location = new System.Drawing.Point(3, 88);
            this.dgvLendDetail.Name = "dgvLendDetail";
            this.dgvLendDetail.RowTemplate.Height = 25;
            this.dgvLendDetail.Size = new System.Drawing.Size(1105, 543);
            this.dgvLendDetail.TabIndex = 0;
            // 
            // gbLendBookSearch
            // 
            this.gbLendBookSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLendBookSearch.Controls.Add(this.btnSearch);
            this.gbLendBookSearch.Controls.Add(this.tbSearch);
            this.gbLendBookSearch.Controls.Add(this.rbLendId);
            this.gbLendBookSearch.Controls.Add(this.rbReaderName);
            this.gbLendBookSearch.Location = new System.Drawing.Point(782, 3);
            this.gbLendBookSearch.Name = "gbLendBookSearch";
            this.gbLendBookSearch.Size = new System.Drawing.Size(326, 79);
            this.gbLendBookSearch.TabIndex = 1;
            this.gbLendBookSearch.TabStop = false;
            this.gbLendBookSearch.Text = "Search Lend Book";
            // 
            // rbReaderName
            // 
            this.rbReaderName.AutoSize = true;
            this.rbReaderName.Location = new System.Drawing.Point(6, 22);
            this.rbReaderName.Name = "rbReaderName";
            this.rbReaderName.Size = new System.Drawing.Size(150, 19);
            this.rbReaderName.TabIndex = 0;
            this.rbReaderName.TabStop = true;
            this.rbReaderName.Text = "Search By Reader Name";
            this.rbReaderName.UseVisualStyleBackColor = true;
            // 
            // rbLendId
            // 
            this.rbLendId.AutoSize = true;
            this.rbLendId.Location = new System.Drawing.Point(162, 22);
            this.rbLendId.Name = "rbLendId";
            this.rbLendId.Size = new System.Drawing.Size(153, 19);
            this.rbLendId.TabIndex = 1;
            this.rbLendId.TabStop = true;
            this.rbLendId.Text = "Search By Lend Ticket ID";
            this.rbLendId.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(6, 47);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(224, 23);
            this.tbSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(240, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gbReturnBook
            // 
            this.gbReturnBook.Controls.Add(this.tbLendTicketId);
            this.gbReturnBook.Controls.Add(this.label2);
            this.gbReturnBook.Controls.Add(this.tbReaderId);
            this.gbReturnBook.Controls.Add(this.label1);
            this.gbReturnBook.Location = new System.Drawing.Point(3, 3);
            this.gbReturnBook.Name = "gbReturnBook";
            this.gbReturnBook.Size = new System.Drawing.Size(205, 79);
            this.gbReturnBook.TabIndex = 2;
            this.gbReturnBook.TabStop = false;
            this.gbReturnBook.Text = "Return Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reader ID";
            // 
            // tbReaderId
            // 
            this.tbReaderId.Location = new System.Drawing.Point(93, 16);
            this.tbReaderId.Name = "tbReaderId";
            this.tbReaderId.Size = new System.Drawing.Size(100, 23);
            this.tbReaderId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lend Ticket ID";
            // 
            // tbLendTicketId
            // 
            this.tbLendTicketId.Location = new System.Drawing.Point(93, 45);
            this.tbLendTicketId.Name = "tbLendTicketId";
            this.tbLendTicketId.Size = new System.Drawing.Size(100, 23);
            this.tbLendTicketId.TabIndex = 3;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(214, 18);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(84, 23);
            this.btnReturnBook.TabIndex = 3;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(214, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // ctrlReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.gbReturnBook);
            this.Controls.Add(this.gbLendBookSearch);
            this.Controls.Add(this.dgvLendDetail);
            this.Name = "ctrlReturnBook";
            this.Size = new System.Drawing.Size(1111, 634);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLendDetail)).EndInit();
            this.gbLendBookSearch.ResumeLayout(false);
            this.gbLendBookSearch.PerformLayout();
            this.gbReturnBook.ResumeLayout(false);
            this.gbReturnBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvLendDetail;
        private GroupBox gbLendBookSearch;
        private RadioButton rbLendId;
        private RadioButton rbReaderName;
        private Button btnSearch;
        private TextBox tbSearch;
        private GroupBox gbReturnBook;
        private TextBox tbLendTicketId;
        private Label label2;
        private TextBox tbReaderId;
        private Label label1;
        private Button btnReturnBook;
        private Button btnRefresh;
    }
}
