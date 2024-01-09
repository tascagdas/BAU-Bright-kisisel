using System;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Config;
using MiniShop.Entity;

namespace MiniShop.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MiniShopDb;user=sa;Password=Tascagdas260636;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());


            base.OnModelCreating(modelBuilder);
        }
    }
}

