﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }


    }
}
