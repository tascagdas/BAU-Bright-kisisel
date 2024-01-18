using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbContext
                .Set<TEntity>()
                .AddAsync(entity);
            await _dbContext
                .SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            List<TEntity> entities = await _dbContext
                .Set<TEntity>()
                .ToListAsync();
            return entities;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            TEntity entity = await _dbContext
                .Set<TEntity>()
                .FindAsync(id);
            return entity;
        }

        public void HardDelete(TEntity entity)
        {
            _dbContext
                .Set<TEntity>()
                .Remove(entity);
            _dbContext .SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbContext
                .Set<TEntity>()
                .Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
