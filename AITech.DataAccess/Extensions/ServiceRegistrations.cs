using AITech.DataAccess.Repositories.CategoryRepositories;
using AITech.DataAccess.Repositories.ProjectRepositories;
using AITech.DataAccess.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {


        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IProjectRepository,ProjectRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }


    }
}
