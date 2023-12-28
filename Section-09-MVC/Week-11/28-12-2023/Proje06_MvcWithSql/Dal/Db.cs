using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
// string connectionString = "Server=localhost;Database=Northwind;user=sa;Password=Tascagdas260636;TrustServerCertificate=true";

namespace Proje06_MvcWithSql.Dal
{
    public static class Db
    {
        private static SqlConnection connection = CreateConnection();
        private static SqlConnection CreateConnection()
        {
            string connectionString = "Server=localhost;Database=Northwind;user=sa;Password=Tascagdas260636;TrustServerCertificate=true";
            return new SqlConnection(connectionString);
        }
        public static void OpenCn()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                Console.WriteLine("Baglanti basariyla kuruldu...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void CloseCn()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                Console.WriteLine("Baglanti durduruldu...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}