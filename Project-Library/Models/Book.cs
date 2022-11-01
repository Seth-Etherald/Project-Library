using System;
using System.Collections.Generic;

namespace Project_Library.Models
{
    public partial class Book
    {
        public Book()
        {
            ReturnBookDetails = new HashSet<ReturnBookDetail>();
            LendBookDetails = new HashSet<LendBookDetail>();
        }

        public int BookId { get; set; }
        public int TitleId { get; set; }
        public int Condition { get; set; }

        public virtual BookInfo Title { get; set; } = null!;
        public virtual ICollection<ReturnBookDetail> ReturnBookDetails { get; set; }

        public virtual ICollection<LendBookDetail> LendBookDetails { get; set; }
    }
}
