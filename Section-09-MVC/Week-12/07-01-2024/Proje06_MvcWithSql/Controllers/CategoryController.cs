using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Proje06_MvcWithSql.Dal;
using Proje06_MvcWithSql.Models;
using Proje06_MvcWithSql.ViewModels;

namespace Proje06_MvcWithSql.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            Db.OpenCn();
            string queryString = @"SELECT 
                                        c.CategoryID as Id,
                                        c.CategoryName as [Category Name],
                                        c.Description as[Categogy Description]
                                    FROM Categories c ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Db.connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            List<CategoryViewModel> categories = new List<CategoryViewModel>();
            CategoryViewModel categoryViewModel = null;
            foreach (DataRow row in dataTable.Rows)
            {
                categories.Add( new CategoryViewModel
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Category Name"].ToString(),
                    Description = row["Categogy Description"].ToString(),
                });
            }


            return View(categories);
        }
    }
}