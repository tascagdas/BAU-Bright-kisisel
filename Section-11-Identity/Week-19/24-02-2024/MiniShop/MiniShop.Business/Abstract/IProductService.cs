using MiniShop.Entity.Concrete;
using MiniShop.Shared.ViewModels;
using MiniShop.Shared.ResponseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IProductService
    {
        #region Generic
        Task<Response<ProductViewModel>> CreateAsync(AddProductViewModel addProductViewModel);
        Task<Response<ProductViewModel>> UpdateAsync(EditProductViewModel editProductViewModel);
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);
        Task<Response<ProductViewModel>> GetByIdAsync(int id);
        Task<Response<List<ProductViewModel>>> GetAllAsync();
        Task<Response<List<ProductViewModel>>> GetAllNonDeletedAsync(bool isDeleted = false);
        Task<Response<List<ProductViewModel>>> GetAllProductsWithCategoriesAsync();
        Task<Response<ProductViewModel>> GetProductWithCategoriesAsync(int id);
        Task<Response<NoContent>> UpdateIsHomeAsync(int id);
        Task<Response<NoContent>> UpdateIsActiveAsync(int id);
        Task<Response<int>> GetActiveProductCount();
        Task<Response<int>> GetProductCount();
        
        #endregion


        #region Product
        Task<Response<List<ProductViewModel>>> GetProductsByCategoryIdAsync(int categoryId);
        #endregion
    }
}
