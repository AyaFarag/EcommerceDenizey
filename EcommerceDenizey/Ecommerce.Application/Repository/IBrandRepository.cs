using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface IBrandRepository : IRepository<Brand>
    {
        Task<List<Brand>> GetBrandwithProductsByBrandId(int brandId);
        Task<List<Product>> DispalyProductsByBrandId(int brandId);
    }
}
