using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WheelsCatalog.Application.contracts.persistence;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Domain.PriceHistoryAggregate.Entities;
using WheelsCatalog.Persistence.Interceptors;
using WheelsCatalog.Persistence.Mappers;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories;

namespace WheelsCatalog.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("WheelsCatalog_Local");

        services.AddDbContext<WheelsCatalogDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<PublishDomainEventsInterceptor>();
            
        services.AddScoped<IEntityMapper<Brand, BrandEntityModel>, BrandMapper>();
        services.AddScoped<IEntityMapper<Car, CarEntityModel>, CarMapper>();
        services.AddScoped<IEntityMapper<CarPhotoEntity, CarPhotoEntityModel>, CarPhotoMapper>();
        services.AddScoped<IEntityMapper<ColorEntity, ColorEntityModel>, ColorMapper>();
        services.AddScoped<IEntityMapper<CurrencyEntity, CurrencyEntityModel>, CurrencyMapper>();
        services.AddScoped<IEntityMapper<Model, ModelEntityModel>, ModelMapper>();
        services.AddScoped<IEntityMapper<PriceHistory, PriceHistoryEntityModel>, PriceHistoryMapper>();
        
        services.AddAutoMapper(
            typeof(BrandMappingProfile), 
            typeof(CarMappingProfile),
            typeof(CarPhotoEntityMappingProfile),
            typeof(ColorEntityMappingProfile),
            typeof(CurrencyMappingProfile),
            typeof(ModelMappingProfile),
            typeof(PriceHistoryMappingProfile)
        );
        
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<ICarPhotoRepository, CarPhotoRepository>();
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IColorRepository, ColorRepository>();
        services.AddScoped<ICurrencyRepository, CurrencyRepository>();
        services.AddScoped<IModelRepository, ModelRepository>();
        services.AddScoped<IPriceHistoryRepository, PriceHistoryRepository>();
        
        return services;
    }
}