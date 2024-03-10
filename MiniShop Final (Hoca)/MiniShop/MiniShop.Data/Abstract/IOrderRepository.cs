using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Abstract
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<List<Order>> GetAllOrdersByProductIdAsync(int productId);
    }
}
