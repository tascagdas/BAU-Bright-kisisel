using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;

namespace MiniShop.Business.Abstract
{
    public interface IShoppingCartService
    {
        Task<Response<NoContent>> InitializeShoppingCartAsync(string userId);
        Task<Response<ShoppingCartViewModel>> GetShoppingCartByUserIdAsync(string userId);
        Task<Response<NoContent>> AddToCartAsync(string userId, int productId, int quantity);


    }
}
