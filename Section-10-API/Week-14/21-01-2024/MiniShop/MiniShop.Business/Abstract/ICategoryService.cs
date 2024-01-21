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
        Task<Response<CategoryDTO>> GetByIdAsync(int id);
        Task<Response<List<CategoryDTO>>> GetAllAsync();
        Task<Response<CategoryDTO>> CreateAsync(AddCategoryDTO addCategoryDTO);
        Task<Response<CategoryDTO>> UpdateAsync(EditCategoryDTO editCategoryDTO);
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);

        #endregion

        #region Category
        Task<Response<List<CategoryDTO>>> GetAllCategoriesWithProductsAsync();
        Task<Response<List<CategoryDTO>>> GetIsDeletedCategories(bool isDeleted);
        Task<Response<List<CategoryDTO>>> GetIsActiveCategories(bool isActive = true);
        //admin panelde kullanilcak bi metot istenildiginde aktif istenildiginde pasif kayitlari getirsin 
        #endregion
    }
}
