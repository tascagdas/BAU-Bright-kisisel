using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Shared.DTOs;

namespace MiniShop.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IMapper _mapper;

        public CategoryManager(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<CategoryDTO> CreaceAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> GetAllCategoriesWithProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> UpdateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}