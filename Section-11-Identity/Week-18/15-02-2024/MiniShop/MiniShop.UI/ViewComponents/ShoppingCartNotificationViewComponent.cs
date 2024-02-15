using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
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
            var user = userName != null ? await _userManager.FindByNameAsync(userName) : null;
            var shoppingCart = user != null ? await _shoppingCartManager.GetShoppingCartByUserIdAsync(user.Id) : null;
            var count = shoppingCart != null ? await _shoppingCartItemManager.CountAsync(shoppingCart.Data.Id) : 0;
            return View(count);
        }
    }
}