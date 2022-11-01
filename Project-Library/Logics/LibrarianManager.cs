using Project_Library.Models;

namespace Project_Library.Logics
{
    internal class LibrarianManager
    {
        public static Librarian? GetLibrarian(int librarianId)
        {
            using var context = new LibraryManagementContext();
            return context.Librarians.FirstOrDefault(x => x.LibrarianId == librarianId);
        }
    }
}