using AITech.Business.Services.GenericServices;
using AITech.DTO.CategoryDtos;

namespace AITech.Business.Services.CategoryServices
{
    public interface ICategoryService: IGenericService<ResultCategoryDto,CreateCategoryDto,UpdateCategoryDto>
    {
    }
}
