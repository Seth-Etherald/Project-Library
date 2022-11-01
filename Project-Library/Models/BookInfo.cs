using System;
using System.Collections.Generic;

namespace Project_Library.Models
{
    public partial class BookInfo
    {
        public BookInfo()
        {
            AuthorBooks = new HashSet<AuthorBook>();
            Books = new HashSet<Book>();
        }

        public int TitleId { get; set; }
        public string Title { get; set; } = null!;
        public int InStock { get; set; }
        public int NumberOfPages { get; set; }
        public int? Frequency { get; set; }
        public int PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; } = null!;
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
