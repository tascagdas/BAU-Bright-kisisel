using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Repositories;

public class OrderRepository:GenericRepository<Order>,IOrderRepository
{
    public OrderRepository(MiniShopDbContext _context):base(_context)
    {
        
    }

    MiniShopDbContext MiniShopDbContext
    {
        get
        {
            return _dbContext as MiniShopDbContext;
        }
    }
}