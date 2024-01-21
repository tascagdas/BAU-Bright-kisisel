using AutoMapper;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Mappings
{
    public class GeneralMappingProfile : Profile
    {
        public GeneralMappingProfile()
        {
            CreateMap<Category, AddCategoryDTO>().ReverseMap();
            CreateMap<Category, EditCategoryDTO>().ReverseMap();


            CreateMap<Product, AddProductDTO>().ReverseMap();
            CreateMap<Product, EditProductDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>()
            // .ForMember(x => x.CategoryList, options => options.MapFrom(y => y.ProductCategories.Select(y => y.Category)))
            .ReverseMap();

            CreateMap<Category, CategoryDTO>()
                .ForMember(cdto => cdto.ProductList, options =>
                    options.MapFrom(c => c.ProductCategories.Select(pc => pc.Product)))
                .ReverseMap();
        }
    }
}
