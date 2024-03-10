﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c=>c.Description).IsRequired().HasMaxLength(500);
            builder.Property(c => c.Url).IsRequired().HasMaxLength(50);
            builder.ToTable("Categories");
            builder.HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Televizyon",
                        Description = "Son model TV'leirn bulunduğu kategorisi",
                        Url = "televizyon"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Bilgisayar",
                        Description = "Süper hızlı Bilgisayarı bulabileceğiniz kategori",
                        Url = "bilgisayar"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Elektronik Eşya",
                        Description = "Elektronik Eşyaların bulunduğu kategorisi",
                        Url = "elektronik-esya"
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "Beyaz Eşya",
                        Description = "Beyaz Eşya kategorisi",
                        Url = "beyaz-esya"
                    },
                    new Category
                    {
                        Id = 5,
                        Name = "Telefon",
                        Description = "Telefon kategorisi",
                        Url = "telefon"
                    }
                );
        }
    }
}
