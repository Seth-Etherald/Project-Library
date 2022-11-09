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
    }
}