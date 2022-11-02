using Project_Library.Logics;
using Project_Library.Models;

namespace Project_Library
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            lbToday.Text = today.ToString("dd/MM/yyyy");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string account = tbAccount.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
                MessageBox.Show("Please enter both username and password!");

            Account? login = AccountManager.GetAccount(account, password);
            if (login != null)
            {
                Librarian? librarian = LibrarianManager.GetLibrarian(login.LibrarianId);
                if (librarian != null)
                {
                    MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK);
                    FrmMain main = new(login, librarian);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error in getting librarian info, please check the database!", "Weird Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Wrong account or password!", "Login Failed", MessageBoxButtons.OK);
                tbPassword.Text = "";
                tbAccount.Focus();
            }
        }

        private void CbShowPW_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbShowPW.Checked;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            e.Cancel = confirm != DialogResult.Yes;
        }
    }
}