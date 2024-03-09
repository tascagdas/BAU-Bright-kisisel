using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId);
        Task<List<Product>> GetProductsByCategoryUrlAsync(string categoryUrl);
        Task ClearProductCategory(int productId, List<int> categoryIds);
    }
}
