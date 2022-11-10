namespace Project_Library
{
    partial class CtrlAccountManager
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
            this.dgvLibrarianInfo = new System.Windows.Forms.DataGridView();
            this.gbLibrarianInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLibrarianId = new System.Windows.Forms.TextBox();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.tbLibrarianName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.cbIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarianInfo)).BeginInit();
            this.gbLibrarianInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibrarianInfo
            // 
            this.dgvLibrarianInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLibrarianInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrarianInfo.Location = new System.Drawing.Point(418, 3);
            this.dgvLibrarianInfo.Name = "dgvLibrarianInfo";
            this.dgvLibrarianInfo.RowTemplate.Height = 25;
            this.dgvLibrarianInfo.Size = new System.Drawing.Size(659, 618);
            this.dgvLibrarianInfo.TabIndex = 0;
            // 
            // gbLibrarianInfo
            // 
            this.gbLibrarianInfo.Controls.Add(this.cbIsAdmin);
            this.gbLibrarianInfo.Controls.Add(this.cbShowPassword);
            this.gbLibrarianInfo.Controls.Add(this.tbPassword);
            this.gbLibrarianInfo.Controls.Add(this.tbEmail);
            this.gbLibrarianInfo.Controls.Add(this.tbLibrarianName);
            this.gbLibrarianInfo.Controls.Add(this.tbAccountName);
            this.gbLibrarianInfo.Controls.Add(this.tbLibrarianId);
            this.gbLibrarianInfo.Controls.Add(this.label5);
            this.gbLibrarianInfo.Controls.Add(this.label4);
            this.gbLibrarianInfo.Controls.Add(this.label3);
            this.gbLibrarianInfo.Controls.Add(this.label2);
            this.gbLibrarianInfo.Controls.Add(this.label1);
            this.gbLibrarianInfo.Location = new System.Drawing.Point(3, 3);
            this.gbLibrarianInfo.Name = "gbLibrarianInfo";
            this.gbLibrarianInfo.Size = new System.Drawing.Size(409, 209);
            this.gbLibrarianInfo.TabIndex = 1;
            this.gbLibrarianInfo.TabStop = false;
            this.gbLibrarianInfo.Text = "Librarian Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LibrarianID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Librarian Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // tbLibrarianId
            // 
            this.tbLibrarianId.Location = new System.Drawing.Point(100, 16);
            this.tbLibrarianId.Name = "tbLibrarianId";
            this.tbLibrarianId.ReadOnly = true;
            this.tbLibrarianId.Size = new System.Drawing.Size(303, 23);
            this.tbLibrarianId.TabIndex = 5;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(100, 45);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(303, 23);
            this.tbAccountName.TabIndex = 6;
            // 
            // tbLibrarianName
            // 
            this.tbLibrarianName.Location = new System.Drawing.Point(100, 74);
            this.tbLibrarianName.Name = "tbLibrarianName";
            this.tbLibrarianName.Size = new System.Drawing.Size(303, 23);
            this.tbLibrarianName.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(100, 103);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(303, 23);
            this.tbEmail.TabIndex = 8;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(100, 132);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(303, 23);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(100, 161);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(108, 19);
            this.cbShowPassword.TabIndex = 10;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.AutoSize = true;
            this.cbIsAdmin.Location = new System.Drawing.Point(100, 186);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(73, 19);
            this.cbIsAdmin.TabIndex = 11;
            this.cbIsAdmin.Text = "Is Admin";
            this.cbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 218);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(230, 218);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ctrlAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gbLibrarianInfo);
            this.Controls.Add(this.dgvLibrarianInfo);
            this.Name = "ctrlAccountManager";
            this.Size = new System.Drawing.Size(1080, 624);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarianInfo)).EndInit();
            this.gbLibrarianInfo.ResumeLayout(false);
            this.gbLibrarianInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvLibrarianInfo;
        private GroupBox gbLibrarianInfo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox cbIsAdmin;
        private CheckBox cbShowPassword;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbLibrarianName;
        private TextBox tbAccountName;
        private TextBox tbLibrarianId;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
