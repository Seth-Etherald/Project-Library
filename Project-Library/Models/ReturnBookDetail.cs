﻿using System;
using System.Collections.Generic;

namespace Project_Library.Models
{
    public partial class ReturnBookDetail
    {
        public int ReturnId { get; set; }
        public int BookId { get; set; }
        public string ReturnCondition { get; set; } = null!;

        public virtual Book Book { get; set; } = null!;
        public virtual ReturnBook Return { get; set; } = null!;
    }
}