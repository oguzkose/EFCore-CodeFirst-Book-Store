﻿using DataAccessLayer.Entities;
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
        public int Add(Author author)
        {
           return _repository.Insert(author);
        }
        public int Update(Author author)
        {
            return _repository.Update(author);
        }

        public Author GetById(int id)
        {
            var entity =_repository.GetById(id);
            return entity;
        }
    }
}
