using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Proje06_MvcWithSql.Dal;
using Proje06_MvcWithSql.Models;
using Proje06_MvcWithSql.ViewModels;

namespace Proje06_MvcWithSql.Controllers;

public class ProductController : Controller
{

    public IActionResult Index()
    {
        Db.OpenCn();
        string queryString = @"SELECT 
                                    p.ProductID ,
                                    p.ProductName as Name,
                                    CAST (p.UnitPrice as decimal(10,2))  as Price,
                                    p.CategoryID as CategoryID ,
                                    p.UnitsInStock  as Stock
                                FROM  Products p ";
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Db.connection);
        DataTable dataTable = new DataTable();
        sqlDataAdapter.Fill(dataTable);
        List<ProductViewModel> products = new List<ProductViewModel>();
        ProductViewModel productViewModel = null;
        foreach (DataRow productRow in dataTable.Rows)
        {
            productViewModel = new ProductViewModel
            {
                Id = Convert.ToInt32(productRow[0]),
                Name = productRow[1].ToString(),
                Price = Convert.ToDecimal(productRow[2]),
                CategoryId = Convert.ToInt32(productRow[3]),
                Stock = Convert.ToInt32(productRow[4]),
            };
            products.Add(productViewModel);
        }
        Db.CloseCn();

        Db.OpenCn();
        queryString = @"SELECT 
                            c.CategoryID as Id,
                            c.CategoryName as [Category Name]
                        FROM Categories c ";
        SqlCommand cmd = new SqlCommand(queryString, Db.connection);
        SqlDataReader reader = cmd.ExecuteReader();
        List<CategoryViewModel> categories = new List<CategoryViewModel>();
        CategoryViewModel category = null;

        while (reader.Read())
        {
            category = new CategoryViewModel
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Category Name"].ToString()

            };
            categories.Add(category);
        }
        Db.CloseCn();

        CategoriesProducts model = new CategoriesProducts
        {
            Categories = categories,
            Products = products
        };

        return View(model);
    }

}
