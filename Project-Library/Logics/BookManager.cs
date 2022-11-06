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

        public static void AddBooks(int amount, int titleId)
        {
            using var context = new LibraryManagementContext();
            BookInfo? temp = BookInfoManager.GetBookInfo(titleId);
            if (temp != null)
            {
                for (int i = 0; i < amount; i++)
                {
                    context.Books.Add(new()
                    {
                        TitleId = titleId,
                        Condition = 1
                    });
                }
                temp.InStock += amount;
                context.BookInfos.Update(temp);
            }
            context.SaveChanges();
        }

        public static void DeleteBooks(List<Book> books)
        {
            using var context = new LibraryManagementContext();
            context.Books.RemoveRange(books);
            context.SaveChanges();
        }
    }
}