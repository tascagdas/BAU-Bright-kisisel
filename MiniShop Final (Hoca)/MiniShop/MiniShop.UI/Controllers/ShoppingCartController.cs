using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.Controllers
{
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

        //Kullanıcının sepetini gösterecek
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);
            return View(shoppingCart.Data);
        }

        [Authorize]
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
        {
            var userId = _userManager.GetUserId(User);
            await _shoppingCartManager.AddToCartAsync(userId, productId, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ChangeQuantity(int itemId, int quantity)
        {
            await _shoppingCartItemManager.ChangeQuantityAsync(itemId, quantity);
            var result = await _shoppingCartItemManager.GetShoppingCartItemAsync(itemId);
            var cartItemTotal = $"{(result.ProductPrice * quantity):C0}";
            var userId = _userManager.GetUserId(User);
            var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);
            var cartTotal = $"{shoppingCart.Data.TotalPrice():C0}";
            var cartSubTotal = $"{(shoppingCart.Data.TotalPrice() / 1.2m):C0}";

            return Json(new
            {
                cartItemTotal = cartItemTotal,
                cartTotal = cartTotal,
                cartSubTotal = cartSubTotal
            });
        }

        public async Task<IActionResult> DeleteItem(int id)
        {
            await _shoppingCartItemManager.DeleteFromShoppingCartAsync(id);
            return RedirectToAction("Index");
        }

        public async Task ClearCart(int id)
        {
            await _shoppingCartItemManager.ClearShoppingCartAsync(id);
        }
    }
}
