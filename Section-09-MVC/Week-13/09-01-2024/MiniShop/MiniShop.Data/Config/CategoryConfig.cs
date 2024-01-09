using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entity;

namespace MiniShop.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);//Bu primary key olmasını sağlıyor
            builder.Property(c => c.Id).ValueGeneratedOnAdd();//Bu identityspecification sağlıyor.
            // modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired();
            // modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                
                .Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .Property(c => c.Url)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .ToTable("Categories");

            builder
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
        }
    }
}