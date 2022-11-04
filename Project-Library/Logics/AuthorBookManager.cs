using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class AuthorBookManager
    {
        public static List<AuthorBook> GetAuthorBooks()
        {
            using var context = new LibraryManagementContext();
            return context.AuthorBooks.ToList();
        }
    }
}