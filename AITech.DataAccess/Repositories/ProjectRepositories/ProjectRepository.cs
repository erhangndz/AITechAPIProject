using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AITech.DataAccess.Repositories.ProjectRepositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext _context) : base(_context)
        {
        }

        public async Task<List<Project>> GetProjectsWithCategoriesAsync()
        {
            return await _context.Projects.AsNoTracking().Include(x=>x.Category).ToListAsync();
        }
    }
}
