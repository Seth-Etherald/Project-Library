namespace Project_Library
{
    partial class ctrlReaderManager
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
            this.gbReaderInfo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbCardCreate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbReaderCard = new System.Windows.Forms.TextBox();
            this.lbReaderCard = new System.Windows.Forms.Label();
            this.lbOccupation = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.gbSearchInfo = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbReaderName = new System.Windows.Forms.RadioButton();
            this.rbReaderCard = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbReaderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            this.gbSearchInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReaderInfo
            // 
            this.gbReaderInfo.Controls.Add(this.textBox2);
            this.gbReaderInfo.Controls.Add(this.lbAddress);
            this.gbReaderInfo.Controls.Add(this.dateTimePicker2);
            this.gbReaderInfo.Controls.Add(this.lbCardCreate);
            this.gbReaderInfo.Controls.Add(this.dateTimePicker1);
            this.gbReaderInfo.Controls.Add(this.lbDateOfBirth);
            this.gbReaderInfo.Controls.Add(this.lbFullName);
            this.gbReaderInfo.Controls.Add(this.tbFullName);
            this.gbReaderInfo.Controls.Add(this.tbReaderCard);
            this.gbReaderInfo.Controls.Add(this.lbReaderCard);
            this.gbReaderInfo.Controls.Add(this.lbOccupation);
            this.gbReaderInfo.Controls.Add(this.comboBox1);
            this.gbReaderInfo.Location = new System.Drawing.Point(3, 3);
            this.gbReaderInfo.Name = "gbReaderInfo";
            this.gbReaderInfo.Size = new System.Drawing.Size(472, 275);
            this.gbReaderInfo.TabIndex = 0;
            this.gbReaderInfo.TabStop = false;
            this.gbReaderInfo.Text = "Reader Information";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 130);
            this.textBox2.TabIndex = 11;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(6, 144);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(49, 15);
            this.lbAddress.TabIndex = 10;
            this.lbAddress.Text = "Address";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(119, 109);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(347, 23);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // lbCardCreate
            // 
            this.lbCardCreate.AutoSize = true;
            this.lbCardCreate.Location = new System.Drawing.Point(6, 116);
            this.lbCardCreate.Name = "lbCardCreate";
            this.lbCardCreate.Size = new System.Drawing.Size(107, 15);
            this.lbCardCreate.TabIndex = 8;
            this.lbCardCreate.Text = "Card Creation Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Location = new System.Drawing.Point(6, 86);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(73, 15);
            this.lbDateOfBirth.TabIndex = 6;
            this.lbDateOfBirth.Text = "Date of birth";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(6, 54);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(61, 15);
            this.lbFullName.TabIndex = 5;
            this.lbFullName.Text = "Full Name";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(119, 51);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(347, 23);
            this.tbFullName.TabIndex = 4;
            // 
            // tbReaderCard
            // 
            this.tbReaderCard.Location = new System.Drawing.Point(366, 22);
            this.tbReaderCard.Name = "tbReaderCard";
            this.tbReaderCard.ReadOnly = true;
            this.tbReaderCard.Size = new System.Drawing.Size(100, 23);
            this.tbReaderCard.TabIndex = 3;
            // 
            // lbReaderCard
            // 
            this.lbReaderCard.AutoSize = true;
            this.lbReaderCard.Location = new System.Drawing.Point(281, 25);
            this.lbReaderCard.Name = "lbReaderCard";
            this.lbReaderCard.Size = new System.Drawing.Size(79, 15);
            this.lbReaderCard.TabIndex = 2;
            this.lbReaderCard.Text = "Card Number";
            // 
            // lbOccupation
            // 
            this.lbOccupation.AutoSize = true;
            this.lbOccupation.Location = new System.Drawing.Point(6, 25);
            this.lbOccupation.Name = "lbOccupation";
            this.lbOccupation.Size = new System.Drawing.Size(69, 15);
            this.lbOccupation.TabIndex = 1;
            this.lbOccupation.Text = "Occupation";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // dgvReader
            // 
            this.dgvReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Location = new System.Drawing.Point(481, 3);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.RowTemplate.Height = 25;
            this.dgvReader.Size = new System.Drawing.Size(687, 618);
            this.dgvReader.TabIndex = 1;
            // 
            // gbSearchInfo
            // 
            this.gbSearchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSearchInfo.Controls.Add(this.btnSearch);
            this.gbSearchInfo.Controls.Add(this.rbReaderName);
            this.gbSearchInfo.Controls.Add(this.rbReaderCard);
            this.gbSearchInfo.Controls.Add(this.textBox1);
            this.gbSearchInfo.Location = new System.Drawing.Point(3, 541);
            this.gbSearchInfo.Name = "gbSearchInfo";
            this.gbSearchInfo.Size = new System.Drawing.Size(472, 80);
            this.gbSearchInfo.TabIndex = 2;
            this.gbSearchInfo.TabStop = false;
            this.gbSearchInfo.Text = "Search Information";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(391, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // rbReaderName
            // 
            this.rbReaderName.AutoSize = true;
            this.rbReaderName.Location = new System.Drawing.Point(101, 22);
            this.rbReaderName.Name = "rbReaderName";
            this.rbReaderName.Size = new System.Drawing.Size(96, 19);
            this.rbReaderName.TabIndex = 2;
            this.rbReaderName.TabStop = true;
            this.rbReaderName.Text = "Reader Name";
            this.rbReaderName.UseVisualStyleBackColor = true;
            // 
            // rbReaderCard
            // 
            this.rbReaderCard.AutoSize = true;
            this.rbReaderCard.Location = new System.Drawing.Point(6, 22);
            this.rbReaderCard.Name = "rbReaderCard";
            this.rbReaderCard.Size = new System.Drawing.Size(89, 19);
            this.rbReaderCard.TabIndex = 1;
            this.rbReaderCard.TabStop = true;
            this.rbReaderCard.Text = "Reader Card";
            this.rbReaderCard.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(23, 296);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(259, 296);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ctrlReaderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gbSearchInfo);
            this.Controls.Add(this.dgvReader);
            this.Controls.Add(this.gbReaderInfo);
            this.Name = "ctrlReaderManager";
            this.Size = new System.Drawing.Size(1171, 624);
            this.gbReaderInfo.ResumeLayout(false);
            this.gbReaderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            this.gbSearchInfo.ResumeLayout(false);
            this.gbSearchInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbReaderInfo;
        private DataGridView dgvReader;
        private GroupBox gbSearchInfo;
        private Button btnSearch;
        private RadioButton rbReaderName;
        private RadioButton rbReaderCard;
        private TextBox textBox1;
        private Label lbOccupation;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Label lbCardCreate;
        private DateTimePicker dateTimePicker1;
        private Label lbDateOfBirth;
        private Label lbFullName;
        private TextBox tbFullName;
        private TextBox tbReaderCard;
        private Label lbReaderCard;
        private TextBox textBox2;
        private Label lbAddress;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
