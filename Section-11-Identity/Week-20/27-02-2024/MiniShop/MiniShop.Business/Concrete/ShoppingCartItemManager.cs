using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ResponseViewModels;

namespace MiniShop.Business.Concrete;

public class ShoppingCartItemManager:IShoppingCartItemService
{
    private readonly IShoppingCartItemRepository _shoppingCartItemRepository;
    private readonly IShoppingCartRepository _shoppingCartRepository;

    public ShoppingCartItemManager(IShoppingCartItemRepository shoppingCartItemRepository, IShoppingCartRepository shoppingCartRepository)
    {
        _shoppingCartItemRepository = shoppingCartItemRepository;
        _shoppingCartRepository = shoppingCartRepository;
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

    public async Task<Response<NoContent>> DeleteFromShoppingCartAsync(int shoppingCartItemId)
    {
        var deleteCart=await _shoppingCartItemRepository.GetByIdAsync(x => x.Id == shoppingCartItemId);
        await _shoppingCartItemRepository.HardDeleteAsync(deleteCart);
        return Response<NoContent>.Success();
    }

    public async Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId)
    {
        //aslinda repository uzerinde bu ise ozel metot yazmistyik ama burada alternatif bir yol kullaniyoruz. bu yol daha performansli
        var cart = await _shoppingCartRepository.GetByIdAsync(x => x.Id == shoppingCartId,source=>source.Include(x=>x.ShoppingCartItems));
        cart.ShoppingCartItems = new List<ShoppingCartItem>();
        await _shoppingCartRepository.UpdateAsync(cart);
        return Response<NoContent>.Success();

    }
}