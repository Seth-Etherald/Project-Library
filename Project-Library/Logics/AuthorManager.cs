using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class AuthorManager
    {
        public static List<Author> GetAuthors()
        {
            using var context = new LibraryManagementContext();
            return context.Authors.ToList();
        }
    }
}