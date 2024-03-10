using AutoMapper;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ViewModels;

namespace MiniShop.Business.Mappings
{
    public class GeneralMappingProfile : Profile
    {
        public GeneralMappingProfile()
        {
            CreateMap<Category, AddCategoryViewModel>().ReverseMap();
            CreateMap<Category, EditCategoryViewModel>().ReverseMap();
            CreateMap<Category, InCategoryViewModel>().ReverseMap();

            CreateMap<Product, AddProductViewModel>().ReverseMap();
            CreateMap<Product, EditProductViewModel>().ReverseMap();

            CreateMap<Product, InProductViewModel>().ReverseMap();

            CreateMap<Product, ProductViewModel>()
                .ForMember(pViewModel => pViewModel.CategoryList, options =>
                    options.MapFrom(p => p.ProductCategories.Select(pc => pc.Category)))
                .ReverseMap();

            CreateMap<Category, CategoryViewModel>()
                .ForMember(cViewModel => cViewModel.ProductList, options =>
                    options.MapFrom(c => c.ProductCategories.Select(pc => pc.Product)))
                .ReverseMap();

            CreateMap<ShoppingCartItemViewModel, ShoppingCartItem>()
                .ForMember(e => e.Product, options =>
                    options.MapFrom(v => new Product { Price = v.ProductPrice, Name = v.ProductName, ImageUrl = v.ProductImageUrl })
                ).ReverseMap();

            CreateMap<ShoppingCart, ShoppingCartViewModel>().ReverseMap();
            CreateMap<Message, MessageViewModel>().ReverseMap();
        }
    }
}
