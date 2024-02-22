using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;

namespace MiniShop.Business.Concrete;

public class OrderManager:IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderManager(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task CreateAsync(Order order)
    {
        await _orderRepository.CreateAsync(order);
    }

    public async Task<List<Order>> GetOrdersAsync()
    {
        var order = await _orderRepository.GetAllAsync(null,
            source => source.Include(x => x.OrderDetails).ThenInclude(y => y.Product));
        return order;
    }

    public async Task<List<Order>> GetOrdersAsync(string userId)
    {
        var orders = await _orderRepository.GetAllAsync(x=>x.UserId==userId,
            source => source.Include(x => x.OrderDetails).ThenInclude(y => y.Product));
        // gelen siparislerin sirasi en ustte olmasi icin 
        orders = orders.OrderByDescending(x => x.Id).ToList();
        //bu siralama tercih edilen bir yontem degil
        //daha sonra bunu degistirecegiz.
        return orders;
    }

    public async Task<Order> GetOrderAsync(int orderId)
    {
        var order = await _orderRepository.GetByIdAsync(x=>x.Id==orderId,
            source => source.Include(x => x.OrderDetails).ThenInclude(y => y.Product));
        return order;
    }

    public Task CancelOrder(int orderId)
    {
        throw new NotImplementedException();
    }
}