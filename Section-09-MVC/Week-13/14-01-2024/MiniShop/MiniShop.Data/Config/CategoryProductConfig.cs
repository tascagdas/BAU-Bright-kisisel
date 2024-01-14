using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Config
{
    public class CategoryProductConfig : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasKey(x => new { x.CategoryId, x.ProductId });
            builder.ToTable("CategoryProducts");
            builder.HasData(
                new CategoryProduct { ProductId=1, CategoryId=3},
                new CategoryProduct { ProductId=1, CategoryId=5},

                new CategoryProduct { ProductId=2, CategoryId=3},
                new CategoryProduct { ProductId=2, CategoryId=5},

                new CategoryProduct { ProductId=3, CategoryId=3},
                new CategoryProduct { ProductId=3, CategoryId=5},

                new CategoryProduct { ProductId=4, CategoryId=3},
                new CategoryProduct { ProductId=4, CategoryId=5},

                new CategoryProduct { ProductId=5, CategoryId=2},
                new CategoryProduct { ProductId=5, CategoryId=3},

                new CategoryProduct { ProductId=6, CategoryId=2},
                new CategoryProduct { ProductId=6, CategoryId=3},

                new CategoryProduct { ProductId=7, CategoryId=3},
                new CategoryProduct { ProductId=7, CategoryId=4},

                new CategoryProduct { ProductId=8, CategoryId=3},
                new CategoryProduct { ProductId=8, CategoryId=4},

                new CategoryProduct { ProductId=9, CategoryId=3},

                new CategoryProduct { ProductId=10, CategoryId=3},
                new CategoryProduct { ProductId=10, CategoryId=4},

                new CategoryProduct { ProductId=11, CategoryId=1},
                new CategoryProduct { ProductId=11, CategoryId=3},
                new CategoryProduct { ProductId=11, CategoryId=4});
        }
    }
}
