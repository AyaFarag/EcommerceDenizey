using AutoMapper;
using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.DTOs;
using Ecommerce.Application.Extentions;
using Ecommerce.Application.Repository;
using Ecommerce.Domain;


namespace Ecommerce.Application.Contracts.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task CreateCategory(DTOCategory categoryDTO)
        {
            var catmapModel = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.AddAsync(catmapModel);
        }

        public async Task UpdateCategory(DTOUpdateCategory category)
        {
            var catmapModel = _mapper.Map<Category>(category);
            await _categoryRepository.UpdateAsync(catmapModel);
        }
        public async Task DeleteCategory(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _categoryRepository.GetAllAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

    

     
    }
}
