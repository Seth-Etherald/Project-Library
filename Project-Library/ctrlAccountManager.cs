using Project_Library.Logics;
using Project_Library.Models;

namespace Project_Library
{
    public partial class CtrlAccountManager : UserControl
    {
        private int _currentId;
        private List<AccountManagerModel> _accounts = new();
        private AccountManagerModel? _selectedAccount;

        public CtrlAccountManager(int currentId)
        {
            InitializeComponent();
            _currentId = currentId;
            LoadDGV();
            InitializeFields();
        }

        private void DgvLibrarianInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedAccount = _accounts[e.RowIndex];
                Account? tempAccount = AccountManager.GetAccount(_selectedAccount.Id);
                if (tempAccount != null)
                {
                    tbLibrarianId.Text = _selectedAccount.Id.ToString();
                    tbAccountName.Text = _selectedAccount.UserName;
                    tbAccountName.ReadOnly = true;
                    tbLibrarianName.Text = _selectedAccount.FullName;
                    tbEmail.Text = _selectedAccount.Mail;
                    tbPassword.Text = tempAccount.Password;
                    cbIsAdmin.Checked = (bool)_selectedAccount.IsAdmin!;
                    cbIsAdmin.Enabled = _currentId != _selectedAccount.Id;
                }
            }
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

        private void CbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }

        public void InitializeFields()
        {
            tbLibrarianId.Text = "";
            tbAccountName.Text = "";
            tbAccountName.ReadOnly = false;
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