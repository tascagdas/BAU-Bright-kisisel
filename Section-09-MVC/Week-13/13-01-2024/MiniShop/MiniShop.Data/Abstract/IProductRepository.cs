using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        //Product'a özgü metot imzalarımızı buraya yazacağız.
        List<Product> GetProductsByCategoryId(int categoryId);
        List<Product> GetHomePageProducts(bool? isHome);
    }
}
