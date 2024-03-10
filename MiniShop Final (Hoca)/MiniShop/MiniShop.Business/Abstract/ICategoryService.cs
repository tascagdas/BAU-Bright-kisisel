using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;

namespace MiniShop.Business.Abstract
{
    public interface ICategoryService
    {
        #region Generic
        Task<Response<CategoryViewModel>> CreateAsync(AddCategoryViewModel addCategoryViewModel);
        Task<Response<CategoryViewModel>> UpdateAsync(EditCategoryViewModel editCategoryViewModel);
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);
        Task<Response<List<CategoryViewModel>>> GetAllAsync();
        Task<Response<CategoryViewModel>> GetByIdAsync(int id);
        Task<Response<CategoryViewModel>> GetByUrlAsync(string url);
        Task<Response<List<CategoryViewModel>>> GetActiveCategories(bool isActive = true);
        Task<Response<List<CategoryViewModel>>> GetNonDeletedCategories(bool isDeleted = false);
        Task<Response<int>> GetActiveCategoryCount();
        Task<Response<int>> GetCategoryCount();

        #endregion

        #region Category
        Task<Response<List<CategoryViewModel>>> GetTopCategories(int n);
        #endregion
    }
}
