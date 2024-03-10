using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Abstract
{
    public interface IShoppingCartRepository : IGenericRepository<ShoppingCart>
    {
        Task<ShoppingCart> GetShoppingCartByUserIdAsync(string userId);
        Task DeleteFromShoppingCartAsync(int shoppingCartId, int productId);
        Task ClearShoppingCartAsync(int shoppingCartId);
    }
}
