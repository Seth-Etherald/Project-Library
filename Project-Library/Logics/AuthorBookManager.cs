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

        public static AuthorBook? GetAuthorBookByTitleId(int titleId)
        {
            using var context = new LibraryManagementContext();
            return context.AuthorBooks.FirstOrDefault(x => x.TitleId == titleId);
        }

        public static void AddAuthorBook(AuthorBook data)
        {
            using var context = new LibraryManagementContext();
            context.AuthorBooks.Add(data);
            context.SaveChanges();
        }
    }
}