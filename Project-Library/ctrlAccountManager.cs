using Project_Library.Logics;
using Project_Library.Models;
using System.Diagnostics.Metrics;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

                    btnAdd.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = _currentId != _selectedAccount.Id;
                }
            }
            else
            {
                InitializeFields();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDGV();
            InitializeFields();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Create an account with these information?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string username = tbAccountName.Text.Trim();
                string librarianName = tbLibrarianName.Text.Trim();
                string mail = tbEmail.Text.Trim();
                string password = tbPassword.Text.Trim();
                bool isAdmin = cbIsAdmin.Checked;
                bool valid = ValidateFields(username, password, librarianName, mail);

                if (!valid) return;

                Account? existByName = AccountManager.GetAccount(username);
                if (existByName != null)
                {
                    MessageBox.Show("Account with this username already exist!");
                    tbAccountName.Focus();
                    return;
                }

                Account? existByMail = AccountManager.GetAccount(mail);
                if (existByMail != null)
                {
                    MessageBox.Show("Account with this email already exist!");
                    tbEmail.Focus();
                    return;
                }

                Account newAccount = new()
                {
                    Username = username,
                    Gmail = mail,
                    Password = password,
                    Role = isAdmin ? 0 : 1
                };

                Librarian newLib = new()
                {
                    LibrarianName = librarianName,
                };

                newLib.Accounts.Add(newAccount);
                LibrarianManager.AddLibrarian(newLib);
                MessageBox.Show($"Add new {(isAdmin ? "Admin" : "Librarian")} account successfully");

                LoadDGV();
                InitializeFields();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Update account with these information?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int accountId = Convert.ToInt32(tbLibrarianId.Text);
                string username = tbAccountName.Text.Trim();
                string librarianName = tbLibrarianName.Text.Trim();
                string mail = tbEmail.Text.Trim();
                string password = tbPassword.Text.Trim();
                bool isAdmin = cbIsAdmin.Checked;

                bool valid = ValidateFields(username, password, librarianName, mail);
                if (!valid) return;

                Librarian? libToUpdate = LibrarianManager.GetLibrarian(accountId);
                Account? accToUpdate = AccountManager.GetAccount(username);

                if (libToUpdate != null)
                {
                    libToUpdate.LibrarianName = librarianName;
                    LibrarianManager.UpdateLibrarian(libToUpdate);
                }

                if (accToUpdate != null)
                {
                    accToUpdate.Gmail = mail;
                    accToUpdate.Password = password;
                    accToUpdate.Role = isAdmin ? 0 : 1;
                    AccountManager.UpdateAccount(accToUpdate);
                }

                MessageBox.Show($"Update {(isAdmin ? "Admin" : "Librarian")} account successfully");

                LoadDGV();
                InitializeFields();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int accountId = Convert.ToInt32(tbLibrarianId.Text);
                Librarian? libToDelete = LibrarianManager.GetLibrarian(accountId);
                Account? accToDelete = AccountManager.GetAccount(accountId);
                if (libToDelete != null && accToDelete != null)
                {
                    libToDelete.Accounts.Add(accToDelete);
                    LibrarianManager.DeleteLibrarian(libToDelete);
                    MessageBox.Show("Deleted successfully!");
                }
                LoadDGV();
                InitializeFields();
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

            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private bool ValidateFields(string username, string password, string librarianName, string mail)
        {
            int count = 0;
            foreach (char c in username)
            {
                if (char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Username must not contains whitespaces!");
                    tbAccountName.Focus();
                    return false;
                }
            }

            foreach (char c in password)
            {
                if (char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Password must not contains whitespaces!");
                    tbPassword.Focus();
                    return false;
                }
                else
                {
                    count++;
                }
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username must not be empty!");
                tbAccountName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(librarianName))
            {
                MessageBox.Show("Fullname must not be empty!");
                tbLibrarianName.Focus();
                return false;
            }
            if (!MailAddress.TryCreate(mail, out _))
            {
                MessageBox.Show("Please enter a valid mail address!");
                tbEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password) || count < 4)
            {
                MessageBox.Show("Password must be 4 characters or above!");
                tbPassword.Focus();
                return false;
            }
            return true;
        }
    }
}