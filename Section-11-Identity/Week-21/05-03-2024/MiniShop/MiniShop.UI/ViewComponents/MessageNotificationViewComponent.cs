using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniShop.UI.ViewComponents
{
    public class MessageNotificationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return View();
        }
    }
}