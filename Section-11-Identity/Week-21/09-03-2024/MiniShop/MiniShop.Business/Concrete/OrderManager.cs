using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ComplexTypes;
using MiniShop.Shared.Extensions;
using MiniShop.Shared.ViewModels;

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

    public async Task<List<AdminOrderViewModel>> GetOrdersAsync()
    {
        var orders = await _orderRepository.GetAllAsync(null,
            source => source.Include(x => x.OrderDetails).ThenInclude(y => y.Product).Include(x=>x.User));
        var result = orders.Select(o => new AdminOrderViewModel
        {
            Id = o.Id,
            OrderDate = o.OrderDate,
            UserId = o.UserId,
            UserName = $"{o.FirstName} {o.LastName}",
            OrderState = o.OrderState.GetDisplayName(),
            OrderDetails = o.OrderDetails.Select(od=>new AdminOrderDetailViewModel
            {
                Id = od.Id,
                Price = od.Price,
                Quantity = od.Quantity,
                
                
            }).ToList()
        }).ToList();
        return result.OrderByDescending(x=>x.Id).ToList();
    }

    public async Task<List<AdminOrderViewModel>> GetOrdersAsync(string userId)
    {
        var orders = await _orderRepository.GetAllAsync(x=>x.UserId==userId,
            source => source.Include(x => x.OrderDetails).ThenInclude(y => y.Product));
        
        var result = orders.Select(o => new AdminOrderViewModel
        {
            Id = o.Id,
            OrderDate = o.OrderDate,
            UserId = o.UserId,
            UserName = $"{o.FirstName} {o.LastName}",
            OrderState = o.OrderState.GetDisplayName(),
            OrderDetails = o.OrderDetails.Select(od=>new AdminOrderDetailViewModel
            {
                Id = od.Id,
                Price = od.Price,
                Quantity = od.Quantity,
                Product=new ProductViewModel
                {
                    ImageUrl = od.Product.ImageUrl,
                    Name = od.Product.Name
                }
            }).ToList()
        }).ToList();
        
        
        
        // gelen siparislerin sirasi en ustte olmasi icin 
        result = result.OrderByDescending(x => x.Id).ToList();
        //bu siralama tercih edilen bir yontem degil
        //daha sonra bunu degistirecegiz.
        return result;
    }

    public async Task<List<AdminOrderViewModel>> GetOrdersAsync(int productId)
    {
        var orders = await _orderRepository.GetAllOrdersByProductIdAsync(productId);
        var result = orders.Select(o => new AdminOrderViewModel
        {
            Id = o.Id,
            OrderDate = o.OrderDate,
            UserId = o.UserId,
            UserName = $"{o.FirstName} {o.LastName}",
            OrderDetails = o.OrderDetails.Select(od=>new AdminOrderDetailViewModel
            {
                Id = od.Id,
                Price = od.Price,
                Quantity = od.Quantity
            }).ToList()
        }).ToList();
        
        
        
        // gelen siparislerin sirasi en ustte olmasi icin 
        
        // result = result.OrderByDescending(x => x.Id).ToList();
        
        
        //        Order Repositoryde bu düzeltildi. artık sıralı gelmekte.
        
        
        //bu siralama tercih edilen bir yontem degil
        //daha sonra bunu degistirecegiz. (değişti)
        return result;
    }

    public async Task<AdminOrderViewModel> GetOrderAsync(int orderId)
    {
        var order = await _orderRepository.GetByIdAsync(x=>x.Id==orderId,
            source => source.Include(x => x.OrderDetails).ThenInclude(y => y.Product));
        var result = new AdminOrderViewModel
        {
            Id = orderId,
            OrderDate = order.OrderDate,
            UserId = order.UserId,
            UserName = $"{order.FirstName} {order.LastName}",
            OrderState = order.OrderState.GetDisplayName(),
            OrderDetails = order.OrderDetails.Select(od => new AdminOrderDetailViewModel
            {
                Id = od.Id,
                Price = od.Price,
                Quantity = od.Quantity
            }).ToList()
        };
        return result;
    }

    public async Task<OrderState> UpdateOrderStatus(int orderId, OrderState orderState)
    {
        var order = await _orderRepository.GetByIdAsync(x => x.Id == orderId);
        order.OrderState = orderState;
        await _orderRepository.UpdateAsync(order);
        return orderState;
    }

    public Task CancelOrder(int orderId)
    {
        throw new NotImplementedException();
    }
}