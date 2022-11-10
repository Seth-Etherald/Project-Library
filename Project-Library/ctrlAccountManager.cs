using Project_Library.Logics;
using Project_Library.Models;

namespace Project_Library
{
    public partial class CtrlAccountManager : UserControl
    {
        private int _currentId;
        private List<AccountManagerModel> _accounts = new();

        public CtrlAccountManager(int currentId)
        {
            InitializeComponent();
            _currentId = currentId;
            LoadDGV();
            InitializeFields();
        }

        public void LoadDGV()
        {
            List<Account> tempAccounts = AccountManager.GetAccounts();
            List<Librarian> tempLibrarians = LibrarianManager.GetLibrarians();

            _accounts = (from acc in tempAccounts
                         join lib in tempLibrarians on acc.LibrarianId equals lib.LibrarianId
                         select new AccountManagerModel()
                         {
                             Id = acc.LibrarianId,
                             UserName = acc.Username,
                             FullName = lib.LibrarianName,
                             Mail = acc.Gmail,
                             IsAdmin = acc.Role == 0
                         }).ToList();

            dgvLibrarianInfo.DataSource = _accounts;
        }

        public void InitializeFields()
        {
            tbLibrarianId.Text = "";
            tbAccountName.Text = "";
            tbLibrarianName.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            cbShowPassword.Checked = false;
            cbIsAdmin.Checked = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}