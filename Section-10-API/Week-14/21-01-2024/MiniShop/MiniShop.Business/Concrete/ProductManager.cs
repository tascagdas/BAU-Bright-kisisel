using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;
using MiniShop.Shared.ResponseDTOs;

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

          public async Task<Response<ProductDTO>> CreateAsync(AddProductDTO addProductDTO)
          {
               var product = _mapper.Map<Product>(addProductDTO);
               var createdProduct = await _repository.CreateAsync(product);
               if (createdProduct == null)
               {
                    return Response<ProductDTO>.Fail("Bir hata olustu", 404);
               }

               createdProduct.ProductCategories = addProductDTO.CategoryList
               .Select(c => new ProductCategory
               {
                    ProductId = createdProduct.Id,
                    CategoryId = c.Id
               })
               .ToList();
               await _repository.UpdateAsync(createdProduct);
               var resultProductDto = _mapper.Map<ProductDTO>(createdProduct);
               return Response<ProductDTO>.Success(resultProductDto, 200);
          }

          public async Task<Response<List<ProductDTO>>> GetAllAsync()
          {
               var productList = await _repository.GetAllAsync();
               if (productList == null)
               {
                    return Response<List<ProductDTO>>.Fail("Hiç urun bulunamadı", 301);
               }
               var ProductDtoList = _mapper.Map<List<ProductDTO>>(productList);
               return Response<List<ProductDTO>>.Success(ProductDtoList, 200);
          }

          public async Task<Response<List<ProductDTO>>> GetAllProductsWithCategoriesAsync()
          {
               var productList = await _repository.GetAllProductsWithCategoriesAsync();
               if (productList == null)
               {
                    return Response<List<ProductDTO>>.Fail("Hiç urun bulunamadı", 301);
               }
               var productDtoList = _mapper.Map<List<ProductDTO>>(productList);
               return Response<List<ProductDTO>>.Success(productDtoList, 200);
          }

          public async Task<Response<ProductDTO>> GetByIdAsync(int id)
          {
               var product = await _repository.GetByIdAsync(id);
               if (product == null)
               {
                    return Response<ProductDTO>.Fail("ilgili urun bulunamadi.", 404);

               }
               var ProductDto = _mapper.Map<ProductDTO>(product);
               return Response<ProductDTO>.Success(ProductDto, 200);
          }

          public async Task<Response<List<ProductDTO>>> GetProductsByCategoryIdAsync(int categoryId)
          {
               var productList = await _repository.GetProductsByCategoryIdAsync(categoryId);
               if (productList == null)
               {
                    return Response<List<ProductDTO>>.Fail("Hiç urun bulunamadı", 301);
               }
               var productDtoList = _mapper.Map<List<ProductDTO>>(productList);
               return Response<List<ProductDTO>>.Success(productDtoList, 200);
          }

          public async Task<Response<ProductDTO>> GetProductWithCategoriesAsync(int id)
          {
               var product = await _repository.GetProductWithCategoriesAsync(id);
               if (product == null)
               {
                    return Response<ProductDTO>.Fail("ilgili urun bulunamadi.", 404);

               }
               var ProductDto = _mapper.Map<ProductDTO>(product);
               return Response<ProductDTO>.Success(ProductDto, 200);
          }

          public Task<Response<NoContent>> HardDeleteAsync(int id)
          {
               throw new NotImplementedException();
          }

          public Task<Response<NoContent>> SoftDeleteAsync(int id)
          {
               throw new NotImplementedException();
          }

          public Task<Response<ProductDTO>> UpdateAsync(EditProductDTO editProductDTO)
          {
               throw new NotImplementedException();
          }
     }
}