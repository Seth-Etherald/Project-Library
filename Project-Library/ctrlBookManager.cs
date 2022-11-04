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
            rdTitle.Checked = true;
            LoadDGVData();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadDGVData();
            DoFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            rdTitle.Checked = true;
            tbSearch.Text = "";
            LoadDGVData();
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

        private void BtnAddTitle_Click(object sender, EventArgs e)
        {
            FrmTitleManage titleManager = new();
            titleManager.Show();
        }
    }
}