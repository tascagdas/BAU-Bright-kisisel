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

        public async Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            List<Product> products = await MiniShopDbContext
                .Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId))
                .ToListAsync();
            return products;
        }

        public async Task ClearProductCategory(int productId, List<int> categoryIds)
        {
            List<ProductCategory> productCategories = await MiniShopDbContext
                .ProductCategories
                .Where(pc => pc.ProductId == productId)
                .ToListAsync();
            MiniShopDbContext.ProductCategories.RemoveRange(productCategories);
            await MiniShopDbContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetProductsByCategoryUrlAsync(string categoryUrl)
        {
            List<Product> products = await MiniShopDbContext
                .Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .Where(p => p.ProductCategories.Any(pc => pc.Category.Url == categoryUrl))
                .ToListAsync();
            return products;
        }
    }
}
