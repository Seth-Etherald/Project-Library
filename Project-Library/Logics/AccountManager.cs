using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class AccountManager
    {
        public static Account? GetAccount(string account, string password)
        {
            using var context = new LibraryManagementContext();
            return context.Accounts
                .FirstOrDefault(x =>
                x.Username.Equals(account) &&
                x.Password.Equals(password));
        }
    }
}