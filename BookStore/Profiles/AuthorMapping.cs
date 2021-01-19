using AutoMapper;
using BookStore.Models;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Profiles
{
    public class AuthorMapping:Profile
    {
        public AuthorMapping()
        {
            CreateMap<AuthorInsertModel, Author>();
                //.ForMember(x => x.Name, cfg => cfg.MapFrom(y => y.Name))

                //.ForMember(z => z.Birthdate, cfg => cfg.MapFrom(t => t.Birthdate));

                
        }
    }
}
