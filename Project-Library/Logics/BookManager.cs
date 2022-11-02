using Microsoft.EntityFrameworkCore;
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
    }
}