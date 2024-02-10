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
    public class CategoryManager : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repository;

        public CategoryManager(IMapper mapper, ICategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Response<CategoryViewModel>> CreateAsync(AddCategoryViewModel addCategoryViewModel)
        {
            var category = _mapper.Map<Category>(addCategoryViewModel);
            var createdCategory = await _repository.CreateAsync(category);
            if (createdCategory == null)
            {
                return Response<CategoryViewModel>.Fail("Kategori oluşturulamadı");
            }
            var createdCategoryViewModel = _mapper.Map<CategoryViewModel>(createdCategory);
            return Response<CategoryViewModel>.Success(createdCategoryViewModel);
        }

        public async Task<Response<CategoryViewModel>> UpdateAsync(EditCategoryViewModel editCategoryViewModel)
        {
            var editedCategory = _mapper.Map<Category>(editCategoryViewModel);

            if (editedCategory == null)
            {
                return Response<CategoryViewModel>.Fail("Böyle bir kategori bulunamadı");
            }
            editedCategory.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(editedCategory);
            var resultCategoryViewModel = _mapper.Map<CategoryViewModel>(editedCategory);
            return Response<CategoryViewModel>.Success(resultCategoryViewModel);
        }

        public async Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            var category = await _repository.GetByIdAsync(c => c.Id == id);
            if (category == null)
            {
                return Response<NoContent>.Fail("Böyle bir kategori bulunamadı");
            }
            await _repository.HardDeleteAsync(category);
            return Response<NoContent>.Success();
        }

        public async Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            var deletedCategory = await _repository.GetByIdAsync(c => c.Id == id);
            if (deletedCategory == null)
            {
                return Response<NoContent>.Fail("Böyle bir kategori bulunamadı");
            }
            if (deletedCategory.IsDeleted)
            {
                return Response<NoContent>.Fail("Bu kategori zaten silinmiş!");
            }
            deletedCategory.IsDeleted = true;
            deletedCategory.IsActive = false;
            deletedCategory.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(deletedCategory);
            return Response<NoContent>.Success();
        }

        public async Task<Response<List<CategoryViewModel>>> GetAllAsync()
        {
            var categoryList = await _repository.GetAllAsync();
            if (categoryList.Count == 0)
            {
                return Response<List<CategoryViewModel>>.Fail("Hiç kategori bulunamadı");
            }
            var categoryViewModelList = _mapper.Map<List<CategoryViewModel>>(categoryList);
            return Response<List<CategoryViewModel>>.Success(categoryViewModelList);
        }

        public async Task<Response<CategoryViewModel>> GetByIdAsync(int id)
        {
            var category = await _repository.GetByIdAsync(c => c.Id == id, source => source
                .Include(x => x.ProductCategories)
                .ThenInclude(y => y.Product));
            if (category == null)
            {
                return Response<CategoryViewModel>.Fail("Böyle bir kategori bulunamadı");
            }
            var categoryViewModel = _mapper.Map<CategoryViewModel>(category);
            return Response<CategoryViewModel>.Success(categoryViewModel);
        }

        public async Task<Response<List<CategoryViewModel>>> GetActiveCategories(bool isActive = true)
        {
            var categoryList = await _repository.GetAllAsync(c => c.IsActive == isActive && c.IsDeleted==!isActive);
            string status = isActive ? "aktif" : "aktif olmayan";
            if (categoryList.Count == 0)
            {
                return Response<List<CategoryViewModel>>.Fail($"Hiç {status} kategori bulunamadı");
            }
            var categoryViewModelList = _mapper.Map<List<CategoryViewModel>>(categoryList);
            return Response<List<CategoryViewModel>>.Success(categoryViewModelList);
        }

        public async Task<Response<List<CategoryViewModel>>> GetNonDeletedCategories(bool isDeleted = false)
        {
            var categoryList = await _repository.GetAllAsync(c => c.IsDeleted == isDeleted);
            string status = isDeleted ? "silinmiş" : "silinmemiş";
            if (categoryList.Count == 0)
            {
                return Response<List<CategoryViewModel>>.Fail($"Hiç {status} kategori bulunamadı");
            }
            var categoryViewModelList = _mapper.Map<List<CategoryViewModel>>(categoryList);
            return Response<List<CategoryViewModel>>.Success(categoryViewModelList);
        }

        public async Task<Response<int>> GetActiveCategoryCount()
        {
            var count= await _repository.GetCount(c => c.IsActive && !c.IsDeleted);
            return Response<int>.Success(count);
        }

        public async Task<Response<int>> GetCategoryCount()
        {
            var count= await _repository.GetCount(c => !c.IsDeleted);
            return Response<int>.Success(count);
        }

        public async Task<Response<List<CategoryViewModel>>> GetTopCategories(int n)
        {
            var categoryList = await _repository.GetTopCategories(n);
            if (categoryList.Count == 0)
            {
                return Response<List<CategoryViewModel>>.Fail($"Hiç kategori bulunamadı");
            }
            var categoryViewModelList = _mapper.Map<List<CategoryViewModel>>(categoryList);
            return Response<List<CategoryViewModel>>.Success(categoryViewModelList);
        }
    }
}
