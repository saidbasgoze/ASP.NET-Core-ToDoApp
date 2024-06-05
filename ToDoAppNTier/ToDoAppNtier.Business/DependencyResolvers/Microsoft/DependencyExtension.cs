using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using TodoAppNTier.DataAccess.Contexts;
using TodoAppNTier.DataAccess.UnitofWork;
using ToDoAppNTier.Business.Interfaces;
using ToDoAppNTier.Business.Mappings.AutoMapper;
using ToDoAppNTier.Business.Services;
using ToDoAppNTier.Business.ValidationRules;
using ToDoAppNTier.Dtos.WorkDtos;

namespace ToDoAppNTier.Business.DependencyResolvers.DependencyExtension
{
    public static  class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt =>
            {
                opt.UseSqlServer("server=(localdb)\\mssqllocaldb; database=TodoDb; integrated security=true;");
                opt.LogTo(Console.WriteLine, LogLevel.Information);
            });

            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new WorkProfile());
            });

            var mapper = configuration.CreateMapper();

            services.AddSingleton(mapper);

            services.AddScoped<IUow, Uow>();
            services.AddScoped<IWorkService, WorkService>();

            services.AddTransient<IValidator<WorkCreateDto>, WorkCreateDtoValidator>();
            services.AddTransient<IValidator<WorkUpdateDto>, WorkUpdateDtoValidator>();

        }
    }
}
}
