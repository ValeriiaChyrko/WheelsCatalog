using WheelsCatalog.Persistence.Configurations.DataSeeds;

namespace WheelsCatalog.Persistence.Configurations;

public static class DatabaseInitializer
{
    public static void SeedData(WheelsCatalogDbContext context)
    {
        var carPhotos = CarPhotoEntityDataSeed.SeedCarPhotos();
        
        var colors = ColorEntityDataSeed.SeedColors();
        
        var currencies = CurrencyEntityDataSeed.SeedCurrencies();
        var currencyIds = currencies.Select(c => c.Id).ToList();
        var priceHistories = PriceHistoryDataSeed.SeedPriceHistories(currencyIds);
        
        var brands = BrandDataTableSeed.SeedBrands();
        
        var models = ModelDataSeed.SeedModels(brands);
        
        var brandIds = brands.Select(c => c.Id).ToList();
        var colorIds = colors.Select(c => c.Id).ToList();
        var modelIds = models.Select(c => c.Id).ToList();
        var cars = CarDataSeed.SeedCars(brandIds, modelIds, colorIds, carPhotos, priceHistories);
        
        context.Brands.AddRange(brands);
        context.Models.AddRange(models);
        context.Cars.AddRange(cars);
        
        context.SaveChanges();
    }
}