using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class ReaderManager

    {
        public static List<Reader> GetReaders()
        {
            using var context = new LibraryManagementContext();
            return context.Readers.ToList();
        }

        public static Reader? GetReader(int readerCardId)
        {
            using var context = new LibraryManagementContext();
            return context.Readers.FirstOrDefault(x => x.CardNumber == readerCardId);
        }

        public static Reader? GetReader(string fullname)
        {
            using var context = new LibraryManagementContext();
            return context.Readers.FirstOrDefault(x => x.FullName.Contains(fullname, StringComparison.OrdinalIgnoreCase));
        }

        public static void AddReader(Reader data)
        {
            using var context = new LibraryManagementContext();
            context.Readers.Add(data);
            context.SaveChanges();
        }

        public static void UpdateReader(Reader data)
        {
            using var context = new LibraryManagementContext();
            context.Readers.Update(data);
            context.SaveChanges();
        }

        public static void DeleteReader(Reader data)
        {
            using var context = new LibraryManagementContext();
            context.Readers.Remove(data);
            context.SaveChanges();
        }
    }
}