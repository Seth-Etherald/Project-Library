using Project_Library.Models;

namespace Project_Library
{
    public partial class FrmReturnBook : Form
    {
        public FrmReturnBook(ReturnBookModel data, int librarianId)
        {
            InitializeComponent();

            tbTicketId.Text = data.TicketId.ToString();
            tbBookId.Text = data.BookId.ToString();
            tbLibrarianId.Text = librarianId.ToString();
            tbReaderId.Text = data.ReaderCard.ToString();
            tbReaderName.Text = data.ReaderName!.ToString();
            dtpExpectedReturnDate.Value = data.ExpectedReturnDate;
            nudOverdue.Value = (DateTime.Now - data.ExpectedReturnDate).Days;

            var conditions = new[]
            {
                new {Text = "Good", Value = 1},
                new {Text = "Damaged", Value = 2},
                new {Text = "Lost", Value = 3}
            };
            cbReturnCondition.DataSource = conditions;
            cbReturnCondition.DisplayMember = "Text";
            cbReturnCondition.ValueMember = "Value";
            cbReturnCondition.SelectedIndex = 0;
        }
    }
}