using AutoMapper;
using BookStore.Models;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Profiles
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<Book, BookViewModel>()
                .ForMember(x => x.Id,
                configure => configure.MapFrom(y => y.Id))//ID Mapping

                .ForMember(z => z.Name,
                configure => configure.MapFrom(t => t.Name))// Name Mapping

                .ForMember(bookViewModel => bookViewModel.Publisher,
                configure => configure.MapFrom(bookEntity => bookEntity.Publisher.Name))// Publisher Mapping

                .ForMember(bookVm => bookVm.Author,
                cfg => cfg.MapFrom((entity) => getAuthors(entity)));//BookAuthors Mapping

          
        }
        private string getAuthors(Book book)
        {
            var authors = string.Empty;
            foreach (var bookAuthor in book.BookAuthors)
            {
                authors += bookAuthor.Author.Name + " ";
            }
            return authors;
        }
    }
}
