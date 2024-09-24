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
        public Task<IEnumerable<Category>> GetAllCategories();

        public Task<Category> GetCategoryById(int id);

        public Task CreateCategory(DTOCategory categoryDTO);

        public Task UpdateCategory(DTOUpdateCategory category);

        public Task DeleteCategory(int id);
    }
}
