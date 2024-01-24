using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(MiniShopDbContext _context):base(_context)
        {
            
        }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
        public async Task<List<Product>> GetAllProductsWithCategoriesAsync()
        {
            List<Product> products = await MiniShopDbContext
                .Products
                .Include(p=>p.ProductCategories)
                .ThenInclude(pc=>pc.Category)
                .ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            List<Product> products = await MiniShopDbContext
                .Products
                .Include(p=>p.ProductCategories)
                .ThenInclude(pc=>pc.Category)
                .Where(p=>p.ProductCategories.Any(pc=>pc.CategoryId==categoryId))
                .ToListAsync();
            return products;
        }

        public async Task<Product> GetProductWithCategoriesAsync(int id)
        {
            Product product = await MiniShopDbContext
                .Products
                .Where(p => p.Id == id)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .SingleOrDefaultAsync();
            return product;
        }
    }
}
