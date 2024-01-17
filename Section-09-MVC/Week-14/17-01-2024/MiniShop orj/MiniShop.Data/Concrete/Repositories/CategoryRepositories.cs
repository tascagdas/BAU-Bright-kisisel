using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Repositories
{
    public class CategoryRepositories : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepositories(MiniShopDbContext _context) : base(_context)
        {

        }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
        public async Task<List<Category>> GetAllCategoriesWithProductsAsync()
        {
            List<Category> categories = await MiniShopDbContext.Categories.Include(c => c.ProductCategories).ThenInclude(pc => pc.Product).ToListAsync();
            return categories;
        }
    }
}