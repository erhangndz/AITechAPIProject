using AITech.WebUI.Services.CategoryServices;
using AITech.WebUI.Services.ProjectServices;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace AITech.WebUI.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddUIServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<IProjectService,ProjectService>();

            services.AddFluentValidationAutoValidation()
                    .AddFluentValidationClientsideAdapters()
                    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());


        }


    }
}
