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

        private void BtnDeleteTitle_Click(object sender, EventArgs e)
        {
            int titleId = Convert.ToInt32(lbHiddenTitleId.Text);
            DeleteTitle(titleId);
            LoadDGVData();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            FrmQuantity addQuatity = new(Convert.ToInt32(lbHiddenTitleId.Text));
            addQuatity.Show();
            addQuatity.FormClosing += BtnRefresh_Click!;
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete this book?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int titleId = Convert.ToInt32(lbHiddenTitleId.Text);
                int bookId = Convert.ToInt32(lbHiddenBookId.Text);

                BookManager.DeleteBook(bookId, titleId);
                MessageBox.Show("Book deleted successfully!");
                SetInitialRDAndButton();
                LoadDGVData();
            }
            else
            {
                return;
            }
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
                    btnDeleteBook.Enabled = true;
                }
                else
                {
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
                                3 => "Lent",
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

        public static void DeleteTitle(int titleId)
        {
            var result = MessageBox.Show("Do you really want to delete this title and all books with this title?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                List<AuthorBook> authorBooksToDelete = AuthorBookManager.GetAuthorBooks(titleId);
                List<Book> booksToDelete = BookManager.GetBooks(titleId);
                List<BookInfo> bookInfosToDelete = BookInfoManager.GetBookInfos(titleId);

                if (booksToDelete.Count > 0)
                {
                    BookManager.DeleteBooks(booksToDelete);
                }
                AuthorBookManager.DeleteAuthorBook(authorBooksToDelete);
                BookInfoManager.DeleteBookInfo(bookInfosToDelete);

                MessageBox.Show("Deleted Successfully!");
            }
        }
    }
}