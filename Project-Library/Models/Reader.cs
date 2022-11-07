namespace Project_Library.Models
{
    public partial class Reader
    {
        public Reader()
        {
            LendBookDetails = new HashSet<LendBookDetail>();
            ReturnBooks = new HashSet<ReturnBook>();
        }

        public int CardNumber { get; set; }
        public string FullName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public DateTime CardCreationDate { get; set; }
        public string Address { get; set; } = null!;
        public string Occupation { get; set; } = null!;

        public virtual ICollection<LendBookDetail> LendBookDetails { get; set; }
        public virtual ICollection<ReturnBook> ReturnBooks { get; set; }
    }
}