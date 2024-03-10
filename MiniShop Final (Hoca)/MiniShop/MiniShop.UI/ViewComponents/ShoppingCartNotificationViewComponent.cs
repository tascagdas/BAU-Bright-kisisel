using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.ViewComponents
{
    public class ShoppingCartNotificationViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;
        private readonly IShoppingCartItemService _shoppingCartItemManager;
        private readonly IShoppingCartService _shoppingCartManager;

        public ShoppingCartNotificationViewComponent(UserManager<User> userManager, IShoppingCartItemService shoppingCartItemManager, IShoppingCartService shoppingCartManager)
        {
            _userManager = userManager;
            _shoppingCartItemManager = shoppingCartItemManager;
            _shoppingCartManager = shoppingCartManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string userName)
        {
            if (userName != null)
            {
                var user = await _userManager.FindByNameAsync(userName);
                var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(user.Id);
                var count = await _shoppingCartItemManager.CountAsync(shoppingCart.Data.Id);
                return View(count);
            }


            return View(0);
        }
    }
}
