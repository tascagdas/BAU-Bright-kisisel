using MiniShop.Entity.Concrete;

namespace MiniShop.Business.Abstract;

public interface IOrderService
{
    Task CreateAsync(Order order);
    Task<List<Order>> GetOrdersAsync();
    Task<List<Order>> GetOrdersAsync(string userId);
    Task<Order> GetOrderAsync(int orderId);
    Task CancelOrder(int orderId);

}