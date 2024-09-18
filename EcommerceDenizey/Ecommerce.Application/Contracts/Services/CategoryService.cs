using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.Repository;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task CreateCategory(Category category)
        {
            await _categoryRepository.createCategory(category);
        }

        public Task DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

    

        public Task UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
