using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniShop.Entity;

namespace MiniShop.Data.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        //Product'a özgü metot imzalarımızı buraya yazacağız.
        List<Product> GetProductsByCategoryId(int categoryId);
    }
}