using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //domain inmemorybus mediatr
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //domanin handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand,bool>, CourseCommandHandler>();

            //application layer
            services.AddScoped<ICourseService, CourseService>();

            //infra.data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDBContext>();
        }
    }
}
