using Project_Library.Logics;
using Project_Library.Models;

namespace Project_Library
{
    public partial class FrmTitleManage : Form
    {
        public FrmTitleManage()
        {
            InitializeComponent();
            Text = "Add Title";
            LoadComboBox();
            cbAuthor.SelectedIndex = 0;
            cbPublisher.SelectedIndex = 0;
            btnSubmit.Text = "Add";
        }

        public FrmTitleManage(BookInfo bookInfo)
        {
            InitializeComponent();
            Text = "Edit Title";
            AuthorBook? authorBook = AuthorBookManager.GetAuthorBookByTitleId(bookInfo.TitleId);
            tbTitleId.Text = bookInfo.TitleId.ToString();

            tbTitle.Text = bookInfo.Title;
            nudPage.Value = bookInfo.NumberOfPages;

            if (authorBook != null)
            {
                cbAuthor.SelectedValue = authorBook.AuthorId;
            }
            else
            {
                cbAuthor.SelectedIndex = 0;
            }

            cbPublisher.SelectedValue = bookInfo.PublisherId;

            btnSubmit.Text = "Edit";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            int numberOfPages = Convert.ToInt32(nudPage.Value);
            switch (btnSubmit.Text)
            {
                case "Add":
                    bool validCheck = CheckTitleAndPages(title, numberOfPages);
                    if (!validCheck) return;
                    AddTitleToBookInfo(title, numberOfPages);
                    AddToAuthorBook(title);
                    break;

                case "Edit":
                    break;
            }
        }

        private void FrmTitleManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            e.Cancel = confirm != DialogResult.Yes;
        }

        public void LoadComboBox()
        {
            cbAuthor.DataSource = AuthorManager.GetAuthors();
            cbAuthor.DisplayMember = "AuthorName";
            cbAuthor.ValueMember = "AuthorId";

            cbPublisher.DataSource = PublisherManager.GetPublishers();
            cbPublisher.DisplayMember = "PublisherName";
            cbPublisher.ValueMember = "PublisherId";
        }

        public void AddTitleToBookInfo(string title, int pages)
        {
            int publisherId = Convert.ToInt32(cbPublisher.SelectedValue);

            BookInfo? duplicate = BookInfoManager.GetBookInfo(title);

            if (duplicate != null)
            {
                MessageBox.Show("Title already existed!", "Warning", MessageBoxButtons.OK);
                tbTitle.Text = "";
                tbTitle.Focus();
                return;
            }

            BookInfoManager.AddBookInfo(new()
            {
                Title = title,
                InStock = 0,
                NumberOfPages = pages,
                PublisherId = publisherId,
            });
        }

        public void AddToAuthorBook(string title)
        {
            int authorId = Convert.ToInt32(cbAuthor.SelectedValue);

            BookInfo? newlyAdded = BookInfoManager.GetBookInfo(title);
            if (newlyAdded == null)
            {
                MessageBox.Show("Add title failed! Please check the database!", "Warning", MessageBoxButtons.OK);
                return;
            }
            else
            {
                AuthorBookManager.AddAuthorBook(new()
                {
                    AuthorId = authorId,
                    TitleId = newlyAdded.TitleId,
                    AuthorRole = "Chủ biên"
                });
                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK);
                FormClosing -= FrmTitleManage_FormClosing!;
                Close();
            }
        }

        public bool CheckTitleAndPages(string title, int pages)
        {
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title must not be empty!", "Warning", MessageBoxButtons.OK);
                tbTitle.Focus();
                return false;
            }
            else if (pages == 0)
            {
                MessageBox.Show("Invalid number of pages!", "Warning", MessageBoxButtons.OK);
                nudPage.Focus();
                return false;
            }
            return true;
        }
    }
}