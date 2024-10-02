using Ecommerce.Application.Repository;
using Ecommerce.Domain;
using Ecommerce.Infrastructure.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Services
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        public CategoryRepository(DBContextApplication context) : base(context)
        {
        }

        public Task AddMultiProductsToCategory(int categoryId, int[] productId)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategorywithProducts(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
