namespace Project_Library.Models
{
    internal class BookManageModel
    {
        public int BookId { get; set; }
        public int TitleId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public int InStock { get; set; }
        public int NumberOfPages { get; set; }
        public string? Condition { get; set; }
    }
}