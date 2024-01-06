using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Proje06_MvcWithSql.Views.Shared
{
    public class _ProductPartial : PageModel
    {
        private readonly ILogger<_ProductPartial> _logger;

        public _ProductPartial(ILogger<_ProductPartial> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}