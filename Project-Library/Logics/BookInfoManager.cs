using Microsoft.EntityFrameworkCore;
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
    }
}