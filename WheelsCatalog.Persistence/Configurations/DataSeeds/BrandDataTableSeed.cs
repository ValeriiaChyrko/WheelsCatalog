using WheelsCatalog.Domain.BrandAggregate;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class BrandDataTableSeed
{
    public static List<Brand> SeedBrands()
    {
        var brands = new List<Brand>
        {
            Brand.Create("Brand1", "logo1.png", "Description1", DateTime.UtcNow, DateTime.UtcNow),
            Brand.Create("Brand2", "logo2.png", "Description2", DateTime.UtcNow, DateTime.UtcNow),
            Brand.Create("Brand3", "logo3.png", "Description3", DateTime.UtcNow, DateTime.UtcNow),
            Brand.Create("Brand4", "logo4.png", "Description4", DateTime.UtcNow, DateTime.UtcNow),
            Brand.Create("Brand5", "logo5.png", "Description5", DateTime.UtcNow, DateTime.UtcNow),
        };

        return brands;
    }
}