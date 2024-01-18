using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;
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
        Task<CategoryDTO> GetByIdAsync(int id);
        Task<List<CategoryDTO>> GetAllAsync();
        Task<CategoryDTO> CreateAsync(CategoryDTO categoryDTO);
        Task<CategoryDTO> UpdateAsync(CategoryDTO categoryDTO);
        Task HardDeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        #endregion

        #region Category
        Task<List<CategoryDTO>> GetAllCategoriesWithProductsAsync();
        #endregion
    }
}
