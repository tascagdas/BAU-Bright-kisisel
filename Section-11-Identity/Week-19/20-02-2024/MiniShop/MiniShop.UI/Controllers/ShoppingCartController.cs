using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers;

public class ShoppingCartController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly IShoppingCartService _shoppingCartManager;
    private readonly IShoppingCartItemService _shoppingCartItemManager;

    public ShoppingCartController(UserManager<User> userManager, IShoppingCartService shoppingCartManager, IShoppingCartItemService shoppingCartItemManager)
    {
        _userManager = userManager;
        _shoppingCartManager = shoppingCartManager;
        _shoppingCartItemManager = shoppingCartItemManager;
    }

    // Kullanıcının sepetini gösterecek
    public async Task<IActionResult> Index()
    {
        var userId = _userManager.GetUserId(User);
        var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);
        return View(shoppingCart.Data);
    }

    public async Task<IActionResult> AddToCartAsync(int productId,int quantity=1)
    {
        var userId = _userManager.GetUserId(User);
        await _shoppingCartManager.AddToCartAsync(userId, productId, quantity);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> ChangeQuantity(ShoppingCartItemViewModel shoppingCartItemViewModel)
    {
        if (ModelState.IsValid)
        {
            await _shoppingCartItemManager.ChangeQuantityAsync(shoppingCartItemViewModel.Id,
                shoppingCartItemViewModel.Quantity);
            return RedirectToAction("Index");
        }

        return View(shoppingCartItemViewModel);
    }
}