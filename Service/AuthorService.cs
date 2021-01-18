using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class AuthorService
    {
        private readonly AuthorRepository _repository;
        public AuthorService(AuthorRepository repository)
        {
            _repository = repository;
        }
        public void Add(Author author)
        {
            _repository.Insert(author);
        }
    }
}
