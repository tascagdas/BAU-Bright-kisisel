using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        protected readonly DbContext _dbContext;
        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            List<TEntity> entities = _dbContext.Set<TEntity>().ToList();
            return entities;
        }

        public TEntity GetById(int id)
        {
            TEntity entity = _dbContext.Set<TEntity>().Find(id);
            return entity;
        }

        public void HardDelete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void SoftDelete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
