using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Proje06_MvcWithSql.Views.Shared
{
    public class _CategoriesPartial : PageModel
    {
        private readonly ILogger<_CategoriesPartial> _logger;

        public _CategoriesPartial(ILogger<_CategoriesPartial> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}