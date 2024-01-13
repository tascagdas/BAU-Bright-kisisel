using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .HasMaxLength(100);
            builder.Property(p=>p.Properties)
                .IsRequired()
                .HasMaxLength(1000);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p=>p.ImageUrl).IsRequired();
            builder.ToTable("Products");
            builder.HasData(
                new Product
                {
                    Id=1,
                    Name="IPhone 14",
                    Price=59000,
                    Properties="Harika bir telefon",
                    Url="iphone-14",
                    ImageUrl="1.png",
                    IsHome=true
                },
                new Product
                {
                    Id = 2,
                    Name = "IPhone 14 Pro",
                    Price = 69000,
                    Properties = "Bu da harika bir telefon",
                    Url = "iphone-14-pro",
                    ImageUrl = "2.png",
                    IsHome = false
                },
                new Product
                {
                    Id = 3,
                    Name = "Samsung S23",
                    Price = 49000,
                    Properties = "İdare eder",
                    Url = "samsung-s23",
                    ImageUrl = "3.png",
                    IsHome = true
                },
                new Product
                {
                    Id = 4,
                    Name = "Xaomi Note 4",
                    Price = 39000,
                    Properties = "Harika bir telefon",
                    Url = "xaomi-note-4",
                    ImageUrl = "4.png",
                    IsHome = true
                },
                new Product
                {
                    Id = 5,
                    Name = "MacBook Air M2",
                    Price = 52000,
                    Properties = "M2nin gücü",
                    Url = "macbook-air-m2",
                    ImageUrl = "5.png",
                    IsHome = true
                },
                new Product
                {
                    Id = 6,
                    Name = "MacBook Pro M3",
                    Price = 79000,
                    Properties = "16 Gb ram",
                    Url = "macbook-pro-m3",
                    ImageUrl = "6.png",
                    IsHome = false
                },
                new Product
                {
                    Id = 7,
                    Name = "Vestel Çamaşır Makinesi X65",
                    Price = 19000,
                    Properties = "Akıllı makine",
                    Url = "vestel-camasir-makinesi-x65",
                    ImageUrl = "7.png",
                    IsHome = true
                },
                new Product
                {
                    Id = 8,
                    Name = "Arçelik Çamaşır Makinesi A-4",
                    Price = 21000,
                    Properties = "Süper hızlı makine",
                    Url = "arcelik-camasir-makinesi-a-4",
                    ImageUrl = "8.png",
                    IsHome = false
                }, new Product
                {
                    Id = 9,
                    Name = "Hoop Dijital Radyo X96",
                    Price = 1250,
                    Properties = "Klasik radyo keyfi",
                    Url = "hoop-dijital-radyo-x96",
                    ImageUrl = "9.png",
                    IsHome = true
                },
                new Product
                {
                    Id = 10,
                    Name = "Xaomi Dijital Baskül",
                    Price = 2100,
                    Properties = "Kilonuzu kontrol edin",
                    Url = "xaomi-dijital-baskul",
                    ImageUrl = "10.png",
                    IsHome = true
                },
                new Product
                {
                    Id = 11,
                    Name = "Blaupunkt AC69 Led TV",
                    Price = 9800,
                    Properties = "Android tv",
                    Url = "blaupunkt-ac69-led-tv",
                    ImageUrl = "11.png",
                    IsHome = true
                });
        }
    }
}
