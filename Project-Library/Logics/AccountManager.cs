﻿using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class AccountManager
    {
        public static List<Account> GetAccounts()
        {
            using var context = new LibraryManagementContext();
            return context.Accounts.ToList();
        }

        public static Account? GetAccount(string account, string password)
        {
            using var context = new LibraryManagementContext();
            return context.Accounts
                .FirstOrDefault(x =>
                x.Username.Equals(account) &&
                x.Password.Equals(password));
        }

        public static Account? GetAccount(int id)
        {
            using var context = new LibraryManagementContext();
            return context.Accounts.FirstOrDefault(x => x.LibrarianId == id);
        }
    }
}