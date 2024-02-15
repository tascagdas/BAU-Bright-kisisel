using MiniShop.Shared.ResponseViewModels;

namespace MiniShop.Business.Abstract;

public interface IShoppingCartItemService
{
    Task<Response<NoContent>> ChangeQuantityAsync(int shoppingCartItemId, int quantity);
    Task<int> CountAsync(int shoppingCartId);
}