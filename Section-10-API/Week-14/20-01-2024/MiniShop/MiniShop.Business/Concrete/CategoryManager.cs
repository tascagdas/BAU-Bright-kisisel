using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Shared.DTOs;
using MiniShop.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repository;

        public CategoryManager(IMapper mapper, ICategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<Response<CategoryDTO>> CreateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<CategoryDTO>>> GetAllAsync()
        {
            var categoryList = await _repository.GetAllAsync();
            if(categoryList == null)
            {
                return Response<List<CategoryDTO>>.Fail("Hiç kategori bulunamadı", 301);
            }
            var categoryDtoList = _mapper.Map<List<CategoryDTO>>(categoryList);
            return Response<List<CategoryDTO>>.Success(categoryDtoList, 200);
        }

        public async Task<Response<List<CategoryDTO>>> GetAllCategoriesWithProductsAsync()
        {
            var categoryList = await _repository.GetAllCategoriesWithProductsAsync();
            if (categoryList == null)
            {
                return Response<List<CategoryDTO>>.Fail("Hiç kategori bulunamadı", 301);
            }
            var categoryDtoList = _mapper.Map<List<CategoryDTO>>(categoryList);
            return Response<List<CategoryDTO>>.Success(categoryDtoList,200);
        }
        public Task<Response<CategoryDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CategoryDTO>> UpdateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
