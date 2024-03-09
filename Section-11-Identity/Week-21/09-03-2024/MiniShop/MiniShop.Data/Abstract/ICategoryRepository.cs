using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<List<Category>> GetTopCategories(int n);
    }
}
