using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje06_MvcWithSql.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public decimal Stock { get; set; }
    }
}