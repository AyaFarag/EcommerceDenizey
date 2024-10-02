using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetCategorywithProducts(int categoryId);

        Task AddMultiProductsToCategory(int categoryId, int[] productId);
    }
}
