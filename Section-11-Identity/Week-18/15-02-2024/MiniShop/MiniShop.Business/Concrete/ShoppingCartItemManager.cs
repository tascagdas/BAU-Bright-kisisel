using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Shared.ResponseViewModels;

namespace MiniShop.Business.Concrete;

public class ShoppingCartItemManager:IShoppingCartItemService
{
    private readonly IShoppingCartItemRepository _shoppingCartItemRepository;

    public ShoppingCartItemManager(IShoppingCartItemRepository shoppingCartItemRepository)
    {
        _shoppingCartItemRepository = shoppingCartItemRepository;
    }

    public async Task<Response<NoContent>> ChangeQuantityAsync(int shoppingCartItemId, int quantity)
    {
        var shoppingCartItem = await _shoppingCartItemRepository.GetByIdAsync(x => x.Id == shoppingCartItemId);
        await _shoppingCartItemRepository.ChangeQuantityAsync(shoppingCartItem,quantity);
        return Response<NoContent>.Success();
    }

    public async Task<int> CountAsync(int shoppingCartId)
    {
        return await _shoppingCartItemRepository.GetCount(x=>x.ShoppingCartId==shoppingCartId);
    }
}