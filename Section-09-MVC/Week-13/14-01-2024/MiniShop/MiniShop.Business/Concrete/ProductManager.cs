using MiniShop.Business.Abstract;
using MiniShop.Core.ViewModels;
using MiniShop.Data.Abstract;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var product = new Product
            {
                Name = model.Name,
                Price = model.Price,
                Properties = model.Properties,
                Url = model.Url,
                ImageUrl = model.ImageUrl,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IsActive = true,
                IsHome = model.IsHome
            };
            _productRepository.Create(product);
        }

        public List<ProductViewModel> GetAll(bool? isHome = null, bool? isActive = null, bool? isDelete = null)
        {
            List<Product> products;
            if (isHome == null)
            {
                products = _productRepository.GetAll();
            }
            else
            {
                products = _productRepository.GetHomePageProducts(isHome);
            }
            List<ProductViewModel> productViewModels = products
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Url = p.Url,
                    ImageUrl = p.ImageUrl,
                    Properties = p.Properties
                }).ToList();
            return productViewModels;
        }

        //List<ProductViewModel> productViewModels = new List<ProductViewModel>();
        //ProductViewModel productViewModel;
        //foreach (var product in products)
        //{
        //    productViewModel = new ProductViewModel
        //    {
        //        Id = product.Id,
        //        Name = product.Name,
        //        Price = product.Price,
        //        ImageUrl = product.ImageUrl,
        //        Properties = product.Properties,
        //        Url = product.Url
        //    };
        //    productViewModels.Add(productViewModel);
        //}
        public ProductViewModel GetById(int id)
        {
            Product product = _productRepository.GetById(id);
            ProductViewModel productViewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Url = product.Url,
                ImageUrl = product.ImageUrl,
                Properties = product.Properties,
                IsHome = product.IsHome
            };
            return productViewModel;
        }

        public void HardDelete(int id)
        {
            Product deletedProduct = _productRepository.GetById(id);
            _productRepository.HardDelete(deletedProduct);
        }


        public void SoftDelete(int id)
        {
            Product deletedProduct = _productRepository.GetById(id);
            deletedProduct.IsDelete = !deletedProduct.IsDelete;
            _productRepository.SoftDelete(deletedProduct);
        }

        public void Update(ProductViewModel model)
        {
            Product editedProduct = _productRepository.GetById(model.Id);
            editedProduct.Name = model.Name;
            editedProduct.Price = model.Price;
            editedProduct.Url = model.Url;
            editedProduct.ImageUrl = model.ImageUrl;
            editedProduct.Properties = model.Properties;
            editedProduct.IsHome = model.IsHome;
            _productRepository.Update(editedProduct);
        }
    }
}






