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

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnTitle_Click(object sender, EventArgs e)
        {
            ctrlTitleManager titleManager = new();
            if (!pnMain.Controls.Contains(titleManager))
            {
                pnMain.Controls.Add(titleManager);
                titleManager.Dock = DockStyle.Fill;
                titleManager.BringToFront();
            }
            else
            {
                titleManager.BringToFront();
            }
        }
    }
}