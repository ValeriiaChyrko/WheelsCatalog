using System.Reflection;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.contracts.infrastructure.file;
using WheelsCatalog.Application.profiles;

namespace WheelsCatalog.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped(provider =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new BrandMappingProfile(provider.GetRequiredService<IFileService>())); 
                cfg.AddProfile(new ModelMappingProfile()); 
                cfg.AddProfile(new CarMappingProfile());
            });

            return config.CreateMapper();
        });
        
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddMediatR(cfg => { cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()); });
        
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        return services;
    }
}