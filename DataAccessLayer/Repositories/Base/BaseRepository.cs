using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories.Base
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal readonly BookContext _context;
        public BaseRepository(BookContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var deletedEntity = _context.Find<TEntity>(id);
            _context.Remove(deletedEntity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            var entities = _context.Set<TEntity>().ToList();
            return entities;
        }

        public TEntity GetById(int id)
        {
            var entity = _context.Find<TEntity>(id);
            return entity;
        }

        public int Insert(TEntity entity)
        {
            _context.Add(entity);
           return  _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
