using CleanArchitecture.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.API.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
