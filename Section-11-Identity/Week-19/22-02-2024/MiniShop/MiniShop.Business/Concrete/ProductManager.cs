using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ViewModels;
using MiniShop.Shared.ResponseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;

        public ProductManager(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Response<ProductViewModel>> CreateAsync(AddProductViewModel addProductViewModel)
        {
            var product = _mapper.Map<Product>(addProductViewModel);
            product.CreatedDate = DateTime.Now;
            product.ModifiedDate = DateTime.Now;
            var createdProduct = await _repository.CreateAsync(product);
            if (createdProduct == null)
            {
                return Response<ProductViewModel>.Fail("Bir hata oluştu");
            }
            createdProduct.ProductCategories = addProductViewModel
                .CategoryIds
                .Select(catId => new ProductCategory
                {
                    ProductId = createdProduct.Id,
                    CategoryId = catId
                }).ToList();
            await _repository.UpdateAsync(createdProduct);
            var resultProductViewModel = _mapper.Map<ProductViewModel>(createdProduct);
            return Response<ProductViewModel>.Success(resultProductViewModel);
        }

        public async Task<Response<ProductViewModel>> UpdateAsync(EditProductViewModel editProductViewModel)
        {
            var editedProduct = _mapper.Map<Product>(editProductViewModel);
            if (editedProduct == null)
            {
                return Response<ProductViewModel>.Fail("İlgili ürün bulunamadı.");
            }
            editedProduct.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(editedProduct);
            await _repository.ClearProductCategory(editedProduct.Id, editProductViewModel.CategoryIds);
            editedProduct.ProductCategories = editProductViewModel.CategoryIds.Select(catId =>
                new ProductCategory
                {
                    ProductId = editedProduct.Id,
                    CategoryId = catId
                }).ToList();
            await _repository.UpdateAsync(editedProduct);
            var resultProduct = _mapper.Map<ProductViewModel>(editedProduct);
            return Response<ProductViewModel>.Success(resultProduct);
        }

        public async Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            var product = await _repository.GetByIdAsync(c => c.Id == id);
            if (product == null)
            {
                return Response<NoContent>.Fail("İlgili ürün bulunamadı.");
            }
            await _repository.HardDeleteAsync(product);
            return Response<NoContent>.Success();
        }

        public async Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            var product = await _repository.GetByIdAsync(c => c.Id == id);
            if (product == null)
            {
                return Response<NoContent>.Fail("İlgili ürün bulunamadı.");
            }
            product.IsDeleted = !product.IsDeleted;
            product.IsActive = false;
            product.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(product);
            return Response<NoContent>.Success();
        }

        public async Task<Response<ProductViewModel>> GetByIdAsync(int id)
        {
            var product = await _repository.GetByIdAsync(c => c.Id == id);
            if (product == null)
            {
                return Response<ProductViewModel>.Fail("İlgili ürün bulunamadı.");
            }
            var productViewModel = _mapper.Map<ProductViewModel>(product);
            return Response<ProductViewModel>.Success(productViewModel);
        }

        public async Task<Response<List<ProductViewModel>>> GetAllAsync()
        {
            var productList = await _repository.GetAllAsync();
            if (productList == null)
            {
                return Response<List<ProductViewModel>>.Fail("Hiç ürün bulunamadı");
            }
            var productViewModelList = _mapper.Map<List<ProductViewModel>>(productList);
            return Response<List<ProductViewModel>>.Success(productViewModelList);
        }

        public async Task<Response<List<ProductViewModel>>> GetAllProductsWithCategoriesAsync()
        {
            var productList = await _repository.GetAllAsync(p => p.IsActive && !p.IsDeleted,
                source => source
                    .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category));
            if (productList == null)
            {
                return Response<List<ProductViewModel>>.Fail("Hiç ürün bulunamadı");
            }
            var productViewModelList = _mapper.Map<List<ProductViewModel>>(productList);
            return Response<List<ProductViewModel>>.Success(productViewModelList);
        }

        public async Task<Response<List<ProductViewModel>>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var productList = await _repository.GetProductsByCategoryIdAsync(categoryId);
            if (productList == null)
            {
                return Response<List<ProductViewModel>>.Fail("Bu kategoride hiç ürün bulunamadı");
            }
            var productViewModelList = _mapper.Map<List<ProductViewModel>>(productList);
            return Response<List<ProductViewModel>>.Success(productViewModelList);
        }

        public async Task<Response<ProductViewModel>> GetProductWithCategoriesAsync(int id)
        {
            var product = await _repository.GetByIdAsync(p => !p.IsDeleted && p.Id == id,
                source => source
                    .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category));
            if (product == null)
            {
                return Response<ProductViewModel>.Fail("İlgili ürün bulunamadı.");
            }
            var productViewModel = _mapper.Map<ProductViewModel>(product);
            return Response<ProductViewModel>.Success(productViewModel);
        }

        public async Task<Response<NoContent>> UpdateIsHomeAsync(int id)
        {
            var product = await _repository.GetByIdAsync(p => p.Id == id);
            if (product == null)
            {
                return Response<NoContent>.Fail("İlgili ürün bulunamadı.");
            }
            product.IsHome = !product.IsHome;
            product.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(product);
            return Response<NoContent>.Success();
        }

        public async Task<Response<int>> GetActiveProductCount()
        {
            var count= await _repository.GetCount(p => p.IsActive && !p.IsDeleted);
            return Response<int>.Success(count);
        }

        public async Task<Response<int>> GetProductCount()
        {
            var count = await _repository.GetCount(p => !p.IsDeleted);
            return Response<int>.Success(count);
        }

        public async Task<Response<NoContent>> UpdateIsActiveAsync(int id)
        {
            var product = await _repository.GetByIdAsync(p => p.Id == id);
            if (product == null)
            {
                return Response<NoContent>.Fail("İlgili ürün bulunamadı.");
            }
            product.IsActive = !product.IsActive;
            product.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(product);
            return Response<NoContent>.Success();
        }

        public async Task<Response<List<ProductViewModel>>> GetAllNonDeletedAsync(bool isDeleted=false)
        {
            var productList = await _repository.GetAllAsync(p=>p.IsDeleted == isDeleted);
            if (productList == null)
            {
                return Response<List<ProductViewModel>>.Fail("Hiç ürün bulunamadı");
            }
            var productViewModelList = _mapper.Map<List<ProductViewModel>>(productList);
            return Response<List<ProductViewModel>>.Success(productViewModelList);
        }
    }
}
