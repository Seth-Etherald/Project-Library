using Project_Library.Models;

namespace Project_Library
{
    public partial class FrmMain : Form
    {
        private Account CurrentAccount { get; set; }

        public FrmMain(Account account, Librarian librarian)
        {
            InitializeComponent();
            lbGreeting.Text = $"Hello {librarian.LibrarianName}!";
            CurrentAccount = account;
            if (CurrentAccount.Role == 0) btnAccount.Visible = true;
        }

        private void BtnTitle_Click(object sender, EventArgs e)
        {
            ctrlTitleManager titleManager = new();
            if (!pnMain.Controls.Contains(titleManager))
            {
                pnMain.Controls.Clear();
                pnMain.Controls.Add(titleManager);
                titleManager.Dock = DockStyle.Fill;
                titleManager.BringToFront();
            }
            else
            {
                titleManager.BringToFront();
            }
        }

        private void BtnReader_Click(object sender, EventArgs e)
        {
            ctrlReaderManager readerManager = new();
            if (!pnMain.Controls.Contains(readerManager))
            {
                pnMain.Controls.Clear();
                pnMain.Controls.Add(readerManager);
                readerManager.Dock = DockStyle.Fill;
                readerManager.BringToFront();
            }
            else
            {
                readerManager.BringToFront();
            }
        }

        private void BtnLend_Click(object sender, EventArgs e)
        {
            ctrlLendBook lendManager = new();
            if (!pnMain.Controls.Contains(lendManager))
            {
                pnMain.Controls.Clear();
                pnMain.Controls.Add(lendManager);
                lendManager.Dock = DockStyle.Fill;
                lendManager.BringToFront();
            }
            else
            {
                lendManager.BringToFront();
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ctrlReturnBook returnManager = new();
            if (!pnMain.Controls.Contains(returnManager))
            {
                pnMain.Controls.Clear();
                pnMain.Controls.Add(returnManager);
                returnManager.Dock = DockStyle.Fill;
                returnManager.BringToFront();
            }
            else
            {
                returnManager.BringToFront();
            }
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            ctrlAccountManager accountManager = new();
            if (!pnMain.Controls.Contains(accountManager))
            {
                pnMain.Controls.Clear();
                pnMain.Controls.Add(accountManager);
                accountManager.Dock = DockStyle.Fill;
                accountManager.BringToFront();
            }
            else
            {
                accountManager.BringToFront();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            e.Cancel = confirm != DialogResult.Yes;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}