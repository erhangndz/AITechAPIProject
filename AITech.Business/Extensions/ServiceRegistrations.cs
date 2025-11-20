using AITech.Business.Services.CategoryServices;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.Business.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
        }


    }
}
