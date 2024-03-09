using MiniShop.Entity.Concrete;
using MiniShop.Shared.ComplexTypes;
using MiniShop.Shared.ViewModels;

namespace MiniShop.Business.Abstract;

public interface IOrderService
{
    Task CreateAsync(Order order);
    Task<List<AdminOrderViewModel>> GetOrdersAsync();
    Task<List<AdminOrderViewModel>> GetOrdersAsync(string userId);
    Task<List<AdminOrderViewModel>> GetOrdersAsync(int productId);
    Task<AdminOrderViewModel> GetOrderAsync(int orderId);
    Task<OrderState> UpdateOrderStatus(int id,OrderState orderState);
    Task CancelOrder(int orderId);

}