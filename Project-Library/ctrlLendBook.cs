using Project_Library.Logics;
using Project_Library.Models;

namespace Project_Library
{
    public partial class ctrlLendBook : UserControl
    {
        private readonly int _librarianId;
        private List<BookManageModel> _dgvBookData = new();
        private List<Reader> _readers = new();

        public ctrlLendBook(int librarianId)
        {
            InitializeComponent();
            _librarianId = librarianId;

            dgvReaderInfo.AutoGenerateColumns = false;

            dgvReaderInfo.Columns.Add("CardNumber", "Reader Card Number");
            dgvReaderInfo.Columns["CardNumber"].DataPropertyName = "CardNumber";

            dgvReaderInfo.Columns.Add("FullName", "Reader Name");
            dgvReaderInfo.Columns["FullName"].DataPropertyName = "FullName";

            dgvReaderInfo.Columns.Add("Occupation", "Occupation");
            dgvReaderInfo.Columns["Occupation"].DataPropertyName = "Occupation";
            LoadDGVData();
            InitializeFields();
        }

        public void LoadDGVData()
        {
            List<Book> books = BookManager.GetBooks();
            List<BookInfo> booksInfo = BookInfoManager.GetBookInfos();
            List<Publisher> publishers = PublisherManager.GetPublishers();
            List<Author> authors = AuthorManager.GetAuthors();
            List<AuthorBook> authorBooks = AuthorBookManager.GetAuthorBooks();

            _dgvBookData = (from bookInfo in booksInfo
                            join
                                 publisher in publishers on
                                 bookInfo.PublisherId equals publisher.PublisherId
                            join
                                 authorBook in authorBooks on
                                 bookInfo.TitleId equals authorBook.TitleId
                            join
                                 author in authors on
                                 authorBook.AuthorId equals author.AuthorId
                            join
                                 book in books on
                                 bookInfo.TitleId equals book.TitleId
                                 into groupedData
                            from data in groupedData.DefaultIfEmpty()
                            let condition = data?.Condition switch
                            {
                                1 => "Good",
                                2 => "Damaged",
                                3 => "Lost",
                                _ => "No Data"
                            }
                            select new BookManageModel()
                            {
                                TitleId = bookInfo.TitleId,
                                BookId = data?.BookId == null ? "No book in stock" : data.BookId.ToString(),
                                Title = bookInfo.Title,
                                Author = author.AuthorName,
                                Publisher = publisher.PublisherName,
                                InStock = bookInfo.InStock,
                                NumberOfPages = bookInfo.NumberOfPages,
                                Condition = condition,
                            }).ToList();

            dgvBookInfo.DataSource = _dgvBookData;

            _readers = ReaderManager.GetReaders();
            dgvReaderInfo.DataSource = _readers;
        }

        public void InitializeFields()
        {
            var bookCondition = new[]
            {
                new {Text = "Good", Value = 1},
                new {Text = "Damaged", Value = 2},
                new {Text = "Lost", Value = 3}
            };
            dtpExpReturnDate.MinDate = DateTime.Now;
            rdReaderCard.Checked = true;
            rdBookId.Checked = true;

            tbBookId.Text = "";
            tbLibrarianId.Text = _librarianId.ToString();
            tbReaderId.Text = "";
            dtpExpReturnDate.Value = DateTime.Now;

            cbBookCondition.DataSource = bookCondition;
            cbBookCondition.DisplayMember = "Text";
            cbBookCondition.ValueMember = "Value";
            cbBookCondition.SelectedIndex = 0;
        }
    }
}