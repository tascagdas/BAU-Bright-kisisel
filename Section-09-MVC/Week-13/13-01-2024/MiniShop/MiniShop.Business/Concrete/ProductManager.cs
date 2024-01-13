using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniShop.Business.Abstract;
using MiniShop.Core.ViewModels;
using MiniShop.Data.Abstract;
using MiniShop.Entity;

namespace MiniShop.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public List<ProductViewModel> GetAll(bool? isHome = null, bool? isActive = null, bool? isDeleted = null)
        {
            List<Product> products ;
            if (isHome==null)
            {
                products = _productRepository.GetAll();
            }else
            {
                products = _productRepository.GetHomePageProducts(isHome);
            }
            List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            ProductViewModel productViewModel;
            foreach (var product in products)
            {
                    productViewModel = new ProductViewModel
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        ImageUrl = product.ImageUrl,
                        Properties = product.Properties,
                        Url = product.Url
                    };
                    productViewModels.Add(productViewModel);
            }

            return productViewModels;

        }

        public ProductViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void SoftDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}