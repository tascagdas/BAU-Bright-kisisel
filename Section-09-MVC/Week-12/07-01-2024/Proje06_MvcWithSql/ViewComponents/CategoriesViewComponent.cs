using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Proje06_MvcWithSql.Dal;
using Proje06_MvcWithSql.ViewModels;

namespace Proje06_MvcWithSql.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Db.OpenCn();
            string queryString = @"SELECT 
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
            return View(categories);
        }
    }
}