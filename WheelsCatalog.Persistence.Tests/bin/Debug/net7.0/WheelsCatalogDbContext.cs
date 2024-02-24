using Microsoft.EntityFrameworkCore;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Persistence.Configurations.DataSeeds;
using WheelsCatalog.Persistence.Interceptors;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence;

public class WheelsCatalogDbContext : DbContext
{
    private readonly PublishDomainEventsInterceptor _publishDomainEventsInterceptor;

    public WheelsCatalogDbContext(DbContextOptions<WheelsCatalogDbContext> options,
        PublishDomainEventsInterceptor publishDomainEventsInterceptor) : base(options)
    {
        _publishDomainEventsInterceptor = publishDomainEventsInterceptor;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(WheelsCatalogDbContext).Assembly)
            .Ignore<List<IDomainEvent>>();

        SeedDataBase(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    private static void SeedDataBase(ModelBuilder modelBuilder)
    {
        var brands = BrandDataTableSeed.SeedBrands();
        modelBuilder.Entity<BrandEntityModel>().HasData(brands);
        var models = ModelDataSeed.SeedModels(brands);
        modelBuilder.Entity<ModelEntityModel>().HasData(models);
        var colors = ColorDataTableSeed.SeedColors();
        modelBuilder.Entity<ColorEntityModel>().HasData(colors);
        var cars = CarDataSeed.SeedCars(models, colors);
        modelBuilder.Entity<CarEntityModel>().HasData(cars);
        var carPhotos = CarPhotoDataSeed.SeedCarPhotos(cars);
        modelBuilder.Entity<CarPhotoEntityModel>().HasData(carPhotos);
        var currencies = CurrencyDataTableSeed.SeedCurrencies();
        modelBuilder.Entity<CurrencyEntityModel>().HasData(currencies);
        var priceHistories = PriceHistoryDataSeed.SeedPriceHistories(currencies, cars);
        modelBuilder.Entity<PriceHistoryEntityModel>().HasData(priceHistories);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_publishDomainEventsInterceptor);
        base.OnConfiguring(optionsBuilder);
    }
}