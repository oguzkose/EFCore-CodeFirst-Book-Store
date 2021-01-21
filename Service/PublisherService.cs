using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class PublisherService
    {
        private readonly PublisherRepository _repository;
        public PublisherService(PublisherRepository repository)
        {
            _repository = repository;
        }

        public Publisher GetById(int id)
        {
            return _repository.GetById(id);
        }

        public int Add(Publisher publisher)
        {
            return _repository.Insert(publisher);
        }

        public int Update(Publisher publisher)
        {
            return _repository.Update(publisher);
        }
    }
}
    
