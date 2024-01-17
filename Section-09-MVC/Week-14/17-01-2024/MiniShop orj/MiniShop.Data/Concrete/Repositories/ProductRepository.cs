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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(MiniShopDbContext _context) : base(_context)
        {

        }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
        public Task<Product> CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAllProductsWithCategoriesAsync()
        {
            List<Product> products = await MiniShopDbContext.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            List<Product> products = await MiniShopDbContext
            .Products.Include(p => p.ProductCategories)
            .ThenInclude(pc => pc.Category)
            .Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId))
            .ToListAsync();

            return products;
        }


        public Task<Product> GetProductWithCategoriesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void HardDelete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        async Task<List<Product>> IGenericRepository<Product>.GetAllAsync(int id)
        {
            Product product = await MiniShopDbContext.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Where(p => p.Id == id).SingleOrDefaultAsync();
        }

        Task<Product> IGenericRepository<Product>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}