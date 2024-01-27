using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace MiniShop.Data.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(
            Expression<Func<TEntity, bool>> options = null, Func<IQueryable<TEntity>,
            IIncludableQueryable<TEntity, object>> include = null);
        Task<List<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>> options = null, Func<IQueryable<TEntity>,
            IIncludableQueryable<TEntity, object>> include = null);
        Task<TEntity> CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task HardDeleteAsync(TEntity entity);
        Task<int> GetCount(
            Expression<Func<TEntity, bool>> options = null, Func<IQueryable<TEntity>,
            IIncludableQueryable<TEntity, object>> include = null
        );
    }
}
