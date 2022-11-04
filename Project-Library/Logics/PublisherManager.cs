using Project_Library.Models;

namespace Project_Library.Logics
{
    internal class PublisherManager
    {
        public static List<Publisher> GetPublishers()
        {
            using var context = new LibraryManagementContext();
            return context.Publishers.ToList();
        }
    }
}