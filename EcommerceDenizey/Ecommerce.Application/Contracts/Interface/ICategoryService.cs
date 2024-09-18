using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts.Interface
{
    public interface ICategoryService
    {
        public Task<List<Category>> GetAllCategories();

        public Task<Category> GetCategoryById(int id);

        public Task CreateCategory(Category category);

        public Task UpdateCategory(Category category);

        public Task DeleteCategory(int id);
    }
}
