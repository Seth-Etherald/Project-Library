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
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}