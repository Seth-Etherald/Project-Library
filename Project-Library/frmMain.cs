using Project_Library.Models;

namespace Project_Library
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Account account, Librarian librarian)
        {
            InitializeComponent();
        }
    }
}