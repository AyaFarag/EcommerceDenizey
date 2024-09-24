using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;


namespace Ecommerce.Application.Automapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() 
        {
            CreateMap<DTOCategory, Category>();
            CreateMap<DTOUpdateCategory, Category>();

        }
    }
}
