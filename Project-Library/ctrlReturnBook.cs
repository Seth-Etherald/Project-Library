using Microsoft.EntityFrameworkCore;
using Project_Library.Logics;
using Project_Library.Models;

namespace Project_Library
{
    public partial class CtrlReturnBook : UserControl
    {
        private List<ReturnBookModel> _returns = new();

        public CtrlReturnBook()
        {
            InitializeComponent();
            RefreshElements();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadDGV();
            string filterType = gbLendBookSearch.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked == true)!.Text;
            string searchValue = tbSearch.Text;
            switch (filterType)
            {
                case "By Reader Name":
                    _returns = _returns.Where(x => x.ReaderName!.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
                    break;

                case "By Lend Ticket ID":
                    if (!int.TryParse(searchValue, out _))
                    {
                        MessageBox.Show("Please enter an integer!");
                        tbSearch.Text = "";
                        tbSearch.Focus();
                        return;
                    }
                    _returns = _returns.Where(x => x.TicketId == Convert.ToInt32(searchValue)).ToList();
                    break;
            }
            dgvLendDetail.DataSource = _returns;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshElements();
        }

        public void RefreshElements()
        {
            InitializeFields();
            LoadDGV();
        }

        public void LoadDGV()
        {
            List<LendBookDetail> lendDetails = LendBookManager.GetLendBookDetails();
            List<Reader> readers = ReaderManager.GetReaders();

            _returns = (from ld in lendDetails
                        join
                            r in readers on ld.CardNumber equals r.CardNumber
                        where ld.Books.Count > 0
                        select new ReturnBookModel()
                        {
                            BookId = ld.Books.FirstOrDefault()!.BookId,
                            TicketId = ld.LendBookDetailId,
                            ReaderCard = ld.CardNumber,
                            ReaderName = r.FullName,
                            LibrarianId = ld.LibrarianId,
                            LendDate = ld.LendDate,
                            ExpectedReturnDate = ld.ExpectedReturnDate,
                            LendCondition = ld.ReturnCondition switch
                            {
                                1 => "Good",
                                2 => "Damaged",
                                _ => "No Data"
                            },
                        }).ToList();

            dgvLendDetail.DataSource = _returns;
        }

        public void InitializeFields()
        {
            rbReaderName.Checked = true;
            tbSearch.Text = "";
            btnReturnBook.Enabled = false;
        }
    }
}