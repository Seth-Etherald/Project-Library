namespace Project_Library
{
    partial class ctrlTitleManager
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
            this.dgvTitle = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitle)).BeginInit();
            this.gbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTitle
            // 
            this.dgvTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitle.Location = new System.Drawing.Point(214, 3);
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.RowTemplate.Height = 25;
            this.dgvTitle.Size = new System.Drawing.Size(842, 483);
            this.dgvTitle.TabIndex = 0;
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
            // 
            // btnAddTitle
            // 
            this.btnAddTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTitle.Location = new System.Drawing.Point(3, 328);
            this.btnAddTitle.Name = "btnAddTitle";
            this.btnAddTitle.Size = new System.Drawing.Size(205, 50);
            this.btnAddTitle.TabIndex = 6;
            this.btnAddTitle.Text = "Add Title";
            this.btnAddTitle.UseVisualStyleBackColor = true;
            // 
            // btnEditTitle
            // 
            this.btnEditTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTitle.Location = new System.Drawing.Point(3, 382);
            this.btnEditTitle.Name = "btnEditTitle";
            this.btnEditTitle.Size = new System.Drawing.Size(205, 50);
            this.btnEditTitle.TabIndex = 7;
            this.btnEditTitle.Text = "Edit Title";
            this.btnEditTitle.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.Location = new System.Drawing.Point(3, 436);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(205, 50);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // ctrlTitleManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnEditTitle);
            this.Controls.Add(this.btnAddTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbRadioButtons);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.dgvTitle);
            this.Name = "ctrlTitleManager";
            this.Size = new System.Drawing.Size(1059, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitle)).EndInit();
            this.gbRadioButtons.ResumeLayout(false);
            this.gbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvTitle;
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
    }
}
