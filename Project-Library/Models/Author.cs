using System;
using System.Collections.Generic;

namespace Project_Library.Models
{
    public partial class Author
    {
        public Author()
        {
            AuthorBooks = new HashSet<AuthorBook>();
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = null!;

        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}
