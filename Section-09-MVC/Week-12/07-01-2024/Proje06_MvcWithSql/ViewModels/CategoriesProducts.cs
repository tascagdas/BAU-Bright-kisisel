using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje06_MvcWithSql.ViewModels
{
    public class CategoriesProducts
    {
        public List<CategoryViewModel> Categories { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}