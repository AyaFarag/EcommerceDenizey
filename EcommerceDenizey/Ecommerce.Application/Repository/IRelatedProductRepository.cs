using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface IRelatedProductRepository
    {
        Task AddCategoryToProduct(int productId, int categoryId);

        Task AddBrandToProduct(int productId, int brandId);

        Task<List<Product>> DispalyProductsByCategoryId(int categoryId);

        
    }
}
