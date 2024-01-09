using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entity;

namespace MiniShop.Data.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(1000);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.ImageUrl).IsRequired();
            builder.ToTable("Products");
            builder
            .HasData(
                new Product
                {
                    Id = 1,
                    Name = "Iphone 14",
                    Price = 59000,
                    Properties = "Harika bir telefon",
                    Url = "iphone-14",
                    ImageUrl = "1.png",
                    IsHome = true
                }, new Product
                {
                    Id = 2,
                    Name = "Iphone 14 Pro",
                    Price = 69000,
                    Properties = "Buda harika bir telefon",
                    Url = "iphone-14-pro",
                    ImageUrl = "2.png",
                    IsHome = false
                }, new Product
                {
                    Id = 3,
                    Name = "Samsung S23",
                    Price = 49000,
                    Properties = "İdare eder bir telefon",
                    Url = "samsung-s23",
                    ImageUrl = "3.png",
                    IsHome = true
                }, new Product
                {
                    Id = 4,
                    Name = "Iphone 14",
                    Price = 59000,
                    Properties = "Harika bir telefon",
                    Url = "iphone-14",
                    ImageUrl = "1.png",
                    IsHome = true
                }, new Product
                {
                    Id = 5,
                    Name = "Iphone 14",
                    Price = 59000,
                    Properties = "Harika bir telefon",
                    Url = "iphone-14",
                    ImageUrl = "1.png",
                    IsHome = true
                }, new Product
                {
                    Id = 6,
                    Name = "Iphone 14",
                    Price = 59000,
                    Properties = "Harika bir telefon",
                    Url = "iphone-14",
                    ImageUrl = "1.png",
                    IsHome = true
                }, new Product
                {
                    Id = 7,
                    Name = "Iphone 14",
                    Price = 59000,
                    Properties = "Harika bir telefon",
                    Url = "iphone-14",
                    ImageUrl = "1.png",
                    IsHome = true
                }, new Product
                {
                    Id = 8,
                    Name = "Iphone 14",
                    Price = 59000,
                    Properties = "Harika bir telefon",
                    Url = "iphone-14",
                    ImageUrl = "1.png",
                    IsHome = true
                }, new Product
                {
                    Id = 9,
                    Name = "Iphone 14",
                    Price = 59000,
                    Properties = "Harika bir telefon",
                    Url = "iphone-14",
                    ImageUrl = "1.png",
                    IsHome = true
                }, new Product
                {
                    Id = 10,
                    Name = "Iphone 14",
                    Price = 59000,
                    Properties = "Harika bir telefon",
                    Url = "iphone-14",
                    ImageUrl = "1.png",
                    IsHome = true
                }
            );
        }
    }
}