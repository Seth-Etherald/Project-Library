using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class BookManager
    {
        public static List<Book> GetBooks()
        {
            using var context = new LibraryManagementContext();
            return context.Books.ToList();
        }

        public static List<Book> GetBooks(int titleId)
        {
            using var context = new LibraryManagementContext();
            return context.Books.Where(x => x.TitleId == titleId).ToList();
        }

        public static void DeleteBooks(List<Book> books)
        {
            using var context = new LibraryManagementContext();
            context.Books.RemoveRange(books);
            context.SaveChanges();
        }
    }
}