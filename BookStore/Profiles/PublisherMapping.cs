using AutoMapper;
using BookStore.Models;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Profiles
{
    public class PublisherMapping : Profile
    {
        public PublisherMapping()
        {
            CreateMap<PublisherInsertViewModel, Publisher>();
            CreateMap<Publisher, PublisherUpdateViewModel>();
            CreateMap<PublisherUpdateViewModel, Publisher>();
        }
    }
}
