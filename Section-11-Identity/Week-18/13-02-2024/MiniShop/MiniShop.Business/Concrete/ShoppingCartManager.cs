using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;

namespace MiniShop.Business.Concrete;

public class ShoppingCartManager:IShoppingCartService
{
    private readonly IShoppingCartRepository _shoppingCartRepository;
    private readonly IMapper _mapper;


    public ShoppingCartManager(IShoppingCartRepository shoppingCartRepository, IMapper mapper)
    {
        _shoppingCartRepository = shoppingCartRepository;
        _mapper = mapper;
    }

    public Task<Response<NoContent>> InitializeShoppingCartAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<ShoppingCartViewModel>> GetShoppingCartByUserIdAsync(string userId)
    {
        var shoppingCart = await _shoppingCartRepository.GetShoppingCartByUserIdAsync(userId);
        if (shoppingCart==null)
        {
            return Response<ShoppingCartViewModel>.Fail(
                "ilgili kullanıcının sepetinde sorun var, yöneticiyle görüşünüz.");
        }

        var result = _mapper.Map<ShoppingCartViewModel>(shoppingCart);
        return Response<ShoppingCartViewModel>.Success(result);
    }

    public Task<Response<NoContent>> AddToCartAsync(string userId, string shoppingCartId)
    {
        throw new NotImplementedException();
    }

    public Task<Response<NoContent>> DeleteFromShoppingCartAsync(int shoppingCartId, int productId)
    {
        throw new NotImplementedException();
    }

    public Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId)
    {
        throw new NotImplementedException();
    }
}