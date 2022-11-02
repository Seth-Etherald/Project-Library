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