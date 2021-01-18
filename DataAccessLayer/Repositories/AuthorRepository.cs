using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class AuthorRepository : BaseRepository<Author>
    {
        public AuthorRepository(BookContext context) : base(context)
        {
        }
    }
}
