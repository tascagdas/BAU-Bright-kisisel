using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Task<List<Category>> GetAllCategoriesWithProductsAsync();
        
    }
}