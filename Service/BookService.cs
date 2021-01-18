using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;

namespace Service
{
    public class BookService
    {
        private readonly BookRepository _repository;
        public BookService(BookRepository repository)
        {
            _repository = repository;
        }

        public List<Book> GetAllBooks()
        {
            return _repository.GetAll().ToList();

        }
        //public List<Book> GetBooksWithEagerLoading()
        //{
        //    return _repository.GetBooksWithEagerLoading();
        //}
        
    }
}
