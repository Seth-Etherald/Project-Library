using Project_Library.Logics;
using Project_Library.Models;

namespace Project_Library
{
    public partial class ctrlLendBook : UserControl
    {
        private readonly int _librarianId;
        private List<BookManageModel> _books = new();
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

            LoadReaderDGVData();
            LoadBookDGVData();
            InitializeFields();
        }

        private void DgvReaderInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbReaderId.Text = _readers[e.RowIndex].CardNumber.ToString();
            }
            else
            {
                tbReaderId.Text = "";
            }
        }

        private void BtnReaderSearch_Click(object sender, EventArgs e)
        {
            _readers = ReaderManager.GetReaders();
            string filterType = gbReaderInfo.Controls
                                                     .OfType<RadioButton>()
                                                     .FirstOrDefault(x => x.Checked == true)!.Text;
            switch (filterType)
            {
                case "Reader Card":
                    bool isInt = int.TryParse(tbReaderSearch.Text, out _);
                    if (isInt)
                    {
                        _readers = _readers
                                           .Where(x => x.CardNumber == Convert.ToInt32(tbReaderSearch.Text))
                                           .ToList();
                        dgvReaderInfo.DataSource = _readers;
                    }
                    else
                    {
                        MessageBox.Show("Please enter an integer!");
                        tbReaderSearch.Text = "";
                        tbReaderSearch.Focus();
                    }
                    break;

                case "Reader Name":
                    _readers = _readers
                                       .Where(x => x.FullName.Contains(tbReaderSearch.Text, StringComparison.OrdinalIgnoreCase))
                                       .ToList();
                    dgvReaderInfo.DataSource = _readers;
                    break;
            }
        }

        private void DgvBookInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbBookId.Text = _books[e.RowIndex].BookId;
                cbBookCondition.SelectedValue = _books[e.RowIndex].Condition switch
                {
                    "Good" => 1,
                    "Damaged" => 2,
                    _ => 0
                };
            }
            else
            {
                tbBookId.Text = "";
                cbBookCondition.SelectedIndex = 0;
            }
        }

        private void BtnBookInfoSearch_Click(object sender, EventArgs e)
        {
            LoadBookDGVData();
            string searchString = tbBookInfo.Text.Trim();
            string checkedButton = gbBookInfo.Controls
                                                      .OfType<RadioButton>()
                                                      .FirstOrDefault(x => x.Checked == true)!.Text;
            if (!string.IsNullOrEmpty(searchString))
            {
                switch (checkedButton)
                {
                    case "Book ID":
                        _books = _books.Where(x => x.BookId == searchString).ToList();
                        break;

                    case "Book Name":
                        _books = _books.Where(x => x.Title!.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
                        break;
                }
                dgvBookInfo.DataSource = _books;
            }
        }

        private void BtnRefreshTicket_Click(object sender, EventArgs e)
        {
            RefreshElements();
        }

        public void LoadBookDGVData()
        {
            List<Book> books = BookManager.GetBooks();
            List<BookInfo> booksInfo = BookInfoManager.GetBookInfos();
            List<Publisher> publishers = PublisherManager.GetPublishers();
            List<Author> authors = AuthorManager.GetAuthors();
            List<AuthorBook> authorBooks = AuthorBookManager.GetAuthorBooks();

            _books = (from bookInfo in booksInfo
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
                      from data in groupedData
                      where data?.Condition != 3
                      let condition = data?.Condition switch
                      {
                          1 => "Good",
                          2 => "Damaged",
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

            dgvBookInfo.DataSource = _books;
        }

        public void LoadReaderDGVData()
        {
            _readers = ReaderManager.GetReaders();
            dgvReaderInfo.DataSource = _readers;
        }

        public void InitializeFields()
        {
            var bookCondition = new[]
            {
                new {Text = "Good", Value = 1},
                new {Text = "Damaged", Value = 2}
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

        public void RefreshElements()
        {
            rdReaderCard.Checked = true;
            tbReaderSearch.Text = "";
            LoadReaderDGVData();

            rdBookId.Checked = true;
            tbBookInfo.Text = "";
            LoadBookDGVData();

            tbReaderId.Text = "";
            tbBookId.Text = "";
            dtpExpReturnDate.Value = DateTime.Now;
            cbBookCondition.SelectedIndex = 0;
        }
    }
}