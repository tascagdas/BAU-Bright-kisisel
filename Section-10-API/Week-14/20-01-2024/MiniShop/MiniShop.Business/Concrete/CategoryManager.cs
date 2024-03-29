﻿using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
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

        public async Task<Response<CategoryDTO>> CreateAsync(AddCategoryDTO addcategoryDTO)
        {
            var category = _mapper.Map<Category>(addcategoryDTO);

            var createdCategory = await _repository.CreateAsync(category);
            if (createdCategory == null)
            {
                return Response<CategoryDTO>.Fail("kategori olusturulamadi", 301);
            }
            var createdCategoryDto = _mapper.Map<CategoryDTO>(createdCategory);
            return Response<CategoryDTO>.Success(createdCategoryDto, 200);
        }

        public async Task<Response<List<CategoryDTO>>> GetAllAsync()
        {
            var categoryList = await _repository.GetAllAsync();
            if (categoryList == null)
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
            return Response<List<CategoryDTO>>.Success(categoryDtoList, 200);
        }
        public async Task<Response<CategoryDTO>> GetByIdAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            if (category == null)
            {
                return Response<CategoryDTO>.Fail("boyle bir kategori bulunamadi", 404);
            }
            var categoryDTO = _mapper.Map<CategoryDTO>(category);
            return Response<CategoryDTO>.Success(categoryDTO, 200);
        }

        public async Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            if (category == null)
            {
                return Response<NoContent>.Fail("boyle bir kategori bulunamadi", 404);
            }
            await _repository.HardDeleteAsync(category);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            var deletedCategory = await _repository.GetByIdAsync(id);
            if (deletedCategory == null)
            {
                return Response<NoContent>.Fail("boyle bir kategori bulunamadi", 404);
            }
            deletedCategory.IsDeleted = true;
            deletedCategory.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(deletedCategory);
            return Response<NoContent>.Success(200);

        }

        public async Task<Response<CategoryDTO>> UpdateAsync(EditCategoryDTO editCategoryDTO)
        {
            var editedCategory = _mapper.Map<Category>(editCategoryDTO);
            if (editedCategory == null)
            {
                return Response<CategoryDTO>.Fail("boyle bir kategori bulunamadi", 404);
            }
            editedCategory.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(editedCategory);
            var resultCategoryDto = _mapper.Map<CategoryDTO>(editedCategory);
            return Response<CategoryDTO>.Success(resultCategoryDto, 200);
        }
    }
}
