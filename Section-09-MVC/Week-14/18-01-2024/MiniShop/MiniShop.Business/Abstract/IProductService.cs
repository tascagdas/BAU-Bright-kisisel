using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;
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
        Task<ProductDTO> GetByIdAsync(int id);
        Task<List<ProductDTO>> GetAllAsync();
        Task<ProductDTO> CreateAsync(ProductDTO productDTO);
        Task<ProductDTO> UpdateAsync(ProductDTO productDTO);
        Task HardDeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        #endregion
        #region Product
        Task<List<ProductDTO>> GetAllProductsWithCategoriesAsync();
        Task<List<ProductDTO>> GetProductsByCategoryIdAsync(int categoryId);
        Task<ProductDTO> GetProductWithCategoriesAsync(int id);
        #endregion
    }
}
