using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MiniShopDbContext _context) : base(_context)
        {

        }

        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }

        public async Task<List<Category>> GetTopCategories(int n)
        {
            List<Category> categories = await MiniShopDbContext
                .Categories
                .Where(c => c.IsActive && !c.IsDeleted)
                .Take(n)
                .ToListAsync();
            return categories;
        }
    }
}
