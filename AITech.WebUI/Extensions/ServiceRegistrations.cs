using AITech.WebUI.Services.CategoryServices;

namespace AITech.WebUI.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddUIServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService,CategoryService>();
        }


    }
}
