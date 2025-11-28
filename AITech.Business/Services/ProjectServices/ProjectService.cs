using AITech.DataAccess.Repositories.ProjectRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.ProjectDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.ProjectServices
{
    public class ProjectService(IProjectRepository _projectRepository,
                                IUnitOfWork _unitOfWork) : IProjectService
    {
        public async Task TCreateAsync(CreateProjectDto createDto)
        {
            var project = createDto.Adapt<Project>();
            await _projectRepository.CreateAsync(project);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);
            if (project is null)
            {
                throw new Exception("Proje Bulunamadı");
            }
            _projectRepository.Delete(project);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task<List<ResultProjectDto>> TGetAllAsync()
        {
            var projects = await _projectRepository.GetAllAsync();
            return projects.Adapt<List<ResultProjectDto>>();
        }

        public async Task<ResultProjectDto> TGetByIdAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);
            return project.Adapt<ResultProjectDto>();
        }

        public async Task<List<ResultProjectDto>> TGetProjectsWithCategoriesAsync()
        {
            var projects = await _projectRepository.GetProjectsWithCategoriesAsync();
            return projects.Adapt<List<ResultProjectDto>>();
        }

        public async Task TUpdateAsync(UpdateProjectDto updateDto)
        {
            var project = updateDto.Adapt<Project>();
            _projectRepository.Update(project);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
