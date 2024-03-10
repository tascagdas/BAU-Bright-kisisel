using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Abstract
{
    public interface IShoppingCartItemRepository : IGenericRepository<ShoppingCartItem>
    {
        Task ChangeQuantityAsync(ShoppingCartItem shoppingCartItem, int quantity);
    }
}
