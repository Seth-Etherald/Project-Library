using Project_Library.Logics;
using Project_Library.Models;

namespace Project_Library
{
    public partial class CtrlBookManager : UserControl
    {
        private List<BookManageModel> _dgvBookData = new();

        public CtrlBookManager()
        {
            InitializeComponent();
            SetInitialRDAndButton();
            LoadDGVData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadDGVData();
            DoFilter();
        }

        private void BtnAddTitle_Click(object sender, EventArgs e)
        {
            FrmTitleManage titleManager = new();
            titleManager.Show();
            titleManager.FormClosing += BtnRefresh_Click!;
        }

        private void BtnEditTitle_Click(object sender, EventArgs e)
        {
            FrmTitleManage titleManager = new(Convert.ToInt32(lbHiddenTitleId.Text));
            titleManager.Show();
            titleManager.FormClosing += BtnRefresh_Click!;
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            SetInitialRDAndButton();
            LoadDGVData();
        }

        private void DgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<BookManageModel> booksManage = (List<BookManageModel>)dgvBook.DataSource;
            if (e.RowIndex >= 0)
            {
                btnEditTitle.Enabled = true;
                btnDeleteTitle.Enabled = true;

                lbHiddenBookId.Text = booksManage[e.RowIndex].BookId;
                lbHiddenTitleId.Text = booksManage[e.RowIndex].TitleId.ToString();

                if (!(string.IsNullOrEmpty(lbHiddenBookId.Text) || lbHiddenBookId.Text!.Equals("No book in stock", StringComparison.OrdinalIgnoreCase)))
                {
                    btnEditBook.Enabled = true;
                    btnDeleteBook.Enabled = true;
                }
                else
                {
                    btnEditBook.Enabled = false;
                    btnDeleteBook.Enabled = false;
                }
            }
            else
            {
                SetInitialRDAndButton();
            }
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

            dgvBook.DataSource = _dgvBookData;
        }

        public void SetInitialRDAndButton()
        {
            rdTitle.Checked = true;
            btnEditBook.Enabled = false;
            btnEditTitle.Enabled = false;
            btnDeleteBook.Enabled = false;
            btnDeleteTitle.Enabled = false;
        }

        public void DoFilter()
        {
            string searchString = tbSearch.Text;
            string checkedButton = gbRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked == true)!.Text;
            switch (checkedButton)
            {
                case "Search By Title":
                    _dgvBookData = _dgvBookData.Where(x => x.Title!.Contains(searchString, StringComparison.InvariantCultureIgnoreCase)).ToList();
                    break;

                case "Search By Author":
                    _dgvBookData = _dgvBookData.Where(x => x.Author!.Contains(searchString, StringComparison.InvariantCultureIgnoreCase)).ToList();
                    break;
            }
            dgvBook.DataSource = _dgvBookData;
        }
    }
}