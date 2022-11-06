using Project_Library.Logics;

namespace Project_Library
{
    public partial class FrmQuantity : Form
    {
        private readonly int _titleId;

        public FrmQuantity(int titleId)
        {
            InitializeComponent();
            _titleId = titleId;
        }

        private void BtnAddQuantity_Click(object sender, EventArgs e)
        {
            int quantity = (int)nudQuantity.Value;
            if (quantity > 0)
            {
                var result = MessageBox.Show($"Do you want to add {quantity} book(s) to this title?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BookManager.AddBooks(quantity, _titleId);
                    MessageBox.Show("Book(s) added successfully!", "Success", MessageBoxButtons.OK);
                    FormClosing -= FrmQuantity_FormClosing!;
                    Close();
                }
            }
            else if (quantity < 0)
            {
                MessageBox.Show("Please enter a positive number!", "Warning", MessageBoxButtons.OK);
                nudQuantity.Value = 0;
                nudQuantity.Focus();
            }
        }

        private void FrmQuantity_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            e.Cancel = confirm != DialogResult.Yes;
        }
    }
}