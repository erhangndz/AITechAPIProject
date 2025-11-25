using AITech.WebUI.DTOs.CategoryDtos;

namespace AITech.WebUI.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllAsync();
        Task<UpdateCategoryDto> GetByIdAsync(int id);
        Task CreateAsync(CreateCategoryDto categoryDto);
        Task UpdateAsync(UpdateCategoryDto categoryDto);
        Task DeleteAsync(int id);
    }
}
