using AITech.DataAccess.Repositories.CategoryRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.CategoryDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.CategoryServices
{
    public class CategoryService(
                                ICategoryRepository _categoryRepository,
                                IUnitOfWork _unitOfWork) : ICategoryService
    {
        public async Task TCreateAsync(CreateCategoryDto createDto)
        {
            var category = createDto.Adapt<Category>();
            await _categoryRepository.CreateAsync(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if(category is null)
            {
                throw new Exception(" Kategori Bulunamadı");
            }

            _categoryRepository.Delete(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultCategoryDto>> TGetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.Adapt<List<ResultCategoryDto>>();
        }

        public async Task<ResultCategoryDto> TGetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category is null)
            {
                throw new Exception(" Kategori Bulunamadı");
            }

            return category.Adapt<ResultCategoryDto>();
        }

        public async Task TUpdateAsync(UpdateCategoryDto updateDto)
        {
            var category = updateDto.Adapt<Category>();
            _categoryRepository.Update(category);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
