using AutoMapper;
using CleanArch.Application.Automapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArch.Application.Automapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMapping();
        }
    }
}
