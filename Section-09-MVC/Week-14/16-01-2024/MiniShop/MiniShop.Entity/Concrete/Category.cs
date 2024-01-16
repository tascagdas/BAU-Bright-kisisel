using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniShop.Entity.Abstract;

namespace MiniShop.Entity.Concrete
{
    public class Category:BaseEntity
    {
        public string Description { get; set; }
        public List<ProductCategory> ProductCategories { get; set; } // Navigation Property

    }
}