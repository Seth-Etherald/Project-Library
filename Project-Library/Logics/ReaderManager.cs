using Project_Library.Models;

namespace Project_Library.Logics
{
    internal class ReaderManager
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
    }
}