using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface IImageRepository<T>
    {
        Task addNewImage<T>(int id , IFormFile formFile); // productId 1  // userId 1

        Task deleteImage<T>(int imgId);
    }
}
