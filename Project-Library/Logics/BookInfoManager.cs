using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class BookInfoManager
    {
        public static List<BookInfo> GetBookInfos()
        {
            using var context = new LibraryManagementContext();
            return context.BookInfos.ToList();
        }

        public static BookInfo? GetBookInfo(int titleId)
        {
            using var context = new LibraryManagementContext();
            return context.BookInfos.FirstOrDefault(x => x.TitleId == titleId);
        }

        public static BookInfo? GetBookInfo(string title)
        {
            using var context = new LibraryManagementContext();
            return context.BookInfos.FirstOrDefault(x => x.Title.ToUpper() == title.ToUpper());
        }

        public static void AddBookInfo(BookInfo data)
        {
            using var context = new LibraryManagementContext();
            context.BookInfos.Add(data);
            context.SaveChanges();
        }
    }
}