using AITech.Business.Services.GenericServices;
using AITech.DTO.ProjectDtos;

namespace AITech.Business.Services.ProjectServices
{
    public interface IProjectService: IGenericService<ResultProjectDto,CreateProjectDto,UpdateProjectDto>
    {
        Task<List<ResultProjectDto>> TGetProjectsWithCategoriesAsync();
    }
}
