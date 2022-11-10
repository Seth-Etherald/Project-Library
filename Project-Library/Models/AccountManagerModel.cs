namespace Project_Library.Models
{
    internal class AccountManagerModel
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public string? Mail { get; set; }
        public bool? IsAdmin { get; set; }
    }
}