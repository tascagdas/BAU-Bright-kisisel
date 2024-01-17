using MiniShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Entity.Concrete
{
    public class Product:BaseEntity
    {
        public decimal Price { get; set; }
        public string Properties { get; set; }
        public string ImageUrl { get; set; }
        public bool IsHome { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }//Navigation Property
    }
}
