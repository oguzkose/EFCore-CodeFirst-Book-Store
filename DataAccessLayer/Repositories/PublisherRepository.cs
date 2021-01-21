using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class PublisherRepository : BaseRepository<Publisher>
    {
        public PublisherRepository(BookContext context) : base(context)
        {
        }

    }
    
}
