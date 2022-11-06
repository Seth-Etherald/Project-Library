namespace Project_Library
{
    partial class FrmQuantity
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
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddQuantity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the quantity of books you want to add to this title:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(43, 42);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(243, 23);
            this.nudQuantity.TabIndex = 1;
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.Location = new System.Drawing.Point(124, 82);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuantity.TabIndex = 2;
            this.btnAddQuantity.Text = "Confirm";
            this.btnAddQuantity.UseVisualStyleBackColor = true;
            this.btnAddQuantity.Click += new System.EventHandler(this.BtnAddQuantity_Click);
            // 
            // FrmQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 117);
            this.Controls.Add(this.btnAddQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmQuantity";
            this.Text = "Quantity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuantity_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown nudQuantity;
        private Button btnAddQuantity;
    }
}