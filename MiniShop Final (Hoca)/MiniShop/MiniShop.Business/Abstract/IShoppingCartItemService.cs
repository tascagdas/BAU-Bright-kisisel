using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;

namespace MiniShop.Business.Abstract
{
    public interface IShoppingCartItemService
    {
        Task<Response<NoContent>> ChangeQuantityAsync(int shoppingCartItemId, int quantity);
        Task<int> CountAsync(int shoppingCartId);
        Task<Response<NoContent>> DeleteFromShoppingCartAsync(int shoppingCartItemId);
        Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId);
        Task<ShoppingCartItemViewModel> GetShoppingCartItemAsync(int shoppingCartItemId);

    }
}
