using System;
using Microsoft.EntityFrameworkCore;
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
            #region CategoryProduct
            modelBuilder.Entity<CategoryProduct>().HasKey(x => new { x.CategoryId, x.ProductId });
            #endregion
            #region Category

            modelBuilder.Entity<Category>().HasKey(c => c.Id);//Bu primary key olmasını sağlıyor
            modelBuilder.Entity<Category>().Property(c => c.Id).ValueGeneratedOnAdd();//Bu identityspecification sağlıyor.
            // modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired();
            // modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(50);
            modelBuilder.Entity<Category>().Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder
                .Entity<Category>()
                .Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);

            modelBuilder
                .Entity<Category>()
                .Property(c => c.Url)
                .IsRequired()
                .HasMaxLength(500);

            modelBuilder
                .Entity<Category>()
                .ToTable("Categories");

            modelBuilder
                .Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Televizyon",
                        Description = "Farklı çeşitlerde TV'ler",
                        Url = "televizyon"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Bilgisayar",
                        Description = "Laptop ve masaüstü bilgisayarlar",
                        Url = "bilgisayar"
                    }, new Category
                    {
                        Id = 3,
                        Name = "Elektronik Eşya",
                        Description = "Elektronik eşyalar küçük ev eşyaları vb.",
                        Url = "elektronik-esya"
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "Beyaz Eşya",
                        Description = "Beyaz eşya kategorisi",
                        Url = "beyaz-esya"
                    }


                );
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}

