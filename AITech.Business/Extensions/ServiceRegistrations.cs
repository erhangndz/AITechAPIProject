using AITech.Business.Services.CategoryServices;
using AITech.Business.Services.ProjectServices;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.Business.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProjectService,ProjectService>();
        }


    }
}
