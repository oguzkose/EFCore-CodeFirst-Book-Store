using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories.Base
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
