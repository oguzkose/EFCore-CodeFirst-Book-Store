using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class BookRepository : BaseRepository<Book>
    {
        public BookRepository(BookContext context) : base(context)
        {
        }
        public List<Book> GetBooksWithEagerLoading()
        {
            return _context.Books
                .Include(x=>x.Publisher)
                .ToList();
        }
    }
}
