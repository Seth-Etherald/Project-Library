namespace Project_Library
{
    partial class CtrlBookManager
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
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbRadioButtons = new System.Windows.Forms.GroupBox();
            this.rbAuthor = new System.Windows.Forms.RadioButton();
            this.rdTitle = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddTitle = new System.Windows.Forms.Button();
            this.btnEditTitle = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteTitle = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lbHiddenBookId = new System.Windows.Forms.Label();
            this.lbHiddenTitleId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.gbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(214, 3);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowTemplate.Height = 25;
            this.dgvBook.Size = new System.Drawing.Size(842, 483);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBook_CellClick);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(3, 3);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(42, 15);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(3, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(205, 23);
            this.tbSearch.TabIndex = 2;
            // 
            // gbRadioButtons
            // 
            this.gbRadioButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRadioButtons.Controls.Add(this.rbAuthor);
            this.gbRadioButtons.Controls.Add(this.rdTitle);
            this.gbRadioButtons.Location = new System.Drawing.Point(3, 50);
            this.gbRadioButtons.Name = "gbRadioButtons";
            this.gbRadioButtons.Size = new System.Drawing.Size(205, 81);
            this.gbRadioButtons.TabIndex = 3;
            this.gbRadioButtons.TabStop = false;
            // 
            // rbAuthor
            // 
            this.rbAuthor.AutoSize = true;
            this.rbAuthor.Location = new System.Drawing.Point(6, 47);
            this.rbAuthor.Name = "rbAuthor";
            this.rbAuthor.Size = new System.Drawing.Size(116, 19);
            this.rbAuthor.TabIndex = 1;
            this.rbAuthor.TabStop = true;
            this.rbAuthor.Text = "Search By Author";
            this.rbAuthor.UseVisualStyleBackColor = true;
            // 
            // rdTitle
            // 
            this.rdTitle.AutoSize = true;
            this.rdTitle.Location = new System.Drawing.Point(6, 22);
            this.rdTitle.Name = "rdTitle";
            this.rdTitle.Size = new System.Drawing.Size(101, 19);
            this.rdTitle.TabIndex = 0;
            this.rdTitle.TabStop = true;
            this.rdTitle.Text = "Search By Title";
            this.rdTitle.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(3, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(205, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Start Searching";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(3, 188);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(205, 50);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnAddTitle
            // 
            this.btnAddTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTitle.Location = new System.Drawing.Point(3, 244);
            this.btnAddTitle.Name = "btnAddTitle";
            this.btnAddTitle.Size = new System.Drawing.Size(205, 33);
            this.btnAddTitle.TabIndex = 6;
            this.btnAddTitle.Text = "Add Title";
            this.btnAddTitle.UseVisualStyleBackColor = true;
            this.btnAddTitle.Click += new System.EventHandler(this.BtnAddTitle_Click);
            // 
            // btnEditTitle
            // 
            this.btnEditTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTitle.Location = new System.Drawing.Point(3, 283);
            this.btnEditTitle.Name = "btnEditTitle";
            this.btnEditTitle.Size = new System.Drawing.Size(205, 33);
            this.btnEditTitle.TabIndex = 7;
            this.btnEditTitle.Text = "Edit Title";
            this.btnEditTitle.UseVisualStyleBackColor = true;
            this.btnEditTitle.Click += new System.EventHandler(this.BtnEditTitle_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.Location = new System.Drawing.Point(3, 361);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(205, 33);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // btnDeleteTitle
            // 
            this.btnDeleteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTitle.Location = new System.Drawing.Point(3, 322);
            this.btnDeleteTitle.Name = "btnDeleteTitle";
            this.btnDeleteTitle.Size = new System.Drawing.Size(205, 33);
            this.btnDeleteTitle.TabIndex = 9;
            this.btnDeleteTitle.Text = "Delete Title";
            this.btnDeleteTitle.UseVisualStyleBackColor = true;
            this.btnDeleteTitle.Click += new System.EventHandler(this.BtnDeleteTitle_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBook.Location = new System.Drawing.Point(3, 400);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(205, 33);
            this.btnDeleteBook.TabIndex = 11;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // lbHiddenBookId
            // 
            this.lbHiddenBookId.AutoSize = true;
            this.lbHiddenBookId.Location = new System.Drawing.Point(68, 3);
            this.lbHiddenBookId.Name = "lbHiddenBookId";
            this.lbHiddenBookId.Size = new System.Drawing.Size(69, 15);
            this.lbHiddenBookId.TabIndex = 12;
            this.lbHiddenBookId.Text = "placeholder";
            this.lbHiddenBookId.Visible = false;
            // 
            // lbHiddenTitleId
            // 
            this.lbHiddenTitleId.AutoSize = true;
            this.lbHiddenTitleId.Location = new System.Drawing.Point(143, 3);
            this.lbHiddenTitleId.Name = "lbHiddenTitleId";
            this.lbHiddenTitleId.Size = new System.Drawing.Size(69, 15);
            this.lbHiddenTitleId.TabIndex = 13;
            this.lbHiddenTitleId.Text = "placeholder";
            this.lbHiddenTitleId.Visible = false;
            // 
            // CtrlBookManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.lbHiddenTitleId);
            this.Controls.Add(this.lbHiddenBookId);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnDeleteTitle);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnEditTitle);
            this.Controls.Add(this.btnAddTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbRadioButtons);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.dgvBook);
            this.Name = "CtrlBookManager";
            this.Size = new System.Drawing.Size(1059, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.gbRadioButtons.ResumeLayout(false);
            this.gbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBook;
        private Label lbSearch;
        private TextBox tbSearch;
        private GroupBox gbRadioButtons;
        private RadioButton rbAuthor;
        private RadioButton rdTitle;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnAddTitle;
        private Button btnEditTitle;
        private Button btnAddBook;
        private Button btnDeleteTitle;
        private Button btnDeleteBook;
        private Label lbHiddenBookId;
        private Label lbHiddenTitleId;
    }
}
