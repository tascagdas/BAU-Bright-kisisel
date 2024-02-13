using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;

namespace MiniShop.Business.Abstract;

public interface IShoppingCartService
{
    Task<Response<NoContent>> InitializeShoppingCartAsync(string userId);
    Task<Response<ShoppingCartViewModel>> GetShoppingCartByUserIdAsync(string userId);
    Task<Response<NoContent>> AddToCartAsync(string userId, string shoppingCartId);
    Task<Response<NoContent>> DeleteFromShoppingCartAsync(int shoppingCartId, int productId);
    Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId);
}