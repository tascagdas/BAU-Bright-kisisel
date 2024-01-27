using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;
using MiniShop.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface ICategoryService
    {
        #region Generic
        Task<Response<CategoryDTO>> CreateAsync(AddCategoryDTO addCategoryDTO);
        Task<Response<CategoryDTO>> UpdateAsync(EditCategoryDTO editCategoryDTO);
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);
        Task<Response<List<CategoryDTO>>> GetAllAsync();
        Task<Response<CategoryDTO>> GetByIdAsync(int id);
        Task<Response<List<CategoryDTO>>> GetActiveCategories(bool isActive = true);
        Task<Response<List<CategoryDTO>>> GetNonDeletedCategories(bool isDeleted = false);
        Task<Response<int>> GetActiveCategoryCount();
        Task<Response<int>> GetCategoryCount();

        #endregion

        #region Category

        #endregion
    }
}
