using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds
{
    public static class BrandDataTableSeed
    {
        internal static List<BrandEntityModel> SeedBrands()
        {
            var brands = new List<BrandEntityModel>
            {
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 1",
                    LogoUrl = "https://example.com/logo1.png",
                    Description = "Description for Brand 1",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 2",
                    LogoUrl = "https://example.com/logo2.png",
                    Description = "Description for Brand 2",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 3",
                    LogoUrl = "https://example.com/logo3.png",
                    Description = "Description for Brand 3",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 4",
                    LogoUrl = "https://example.com/logo4.png",
                    Description = "Description for Brand 4",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 5",
                    LogoUrl = "https://example.com/logo5.png",
                    Description = "Description for Brand 5",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 6",
                    LogoUrl = "https://example.com/logo6.png",
                    Description = "Description for Brand 6",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 7",
                    LogoUrl = "https://example.com/logo7.png",
                    Description = "Description for Brand 7",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 8",
                    LogoUrl = "https://example.com/logo8.png",
                    Description = "Description for Brand 8",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 9",
                    LogoUrl = "https://example.com/logo9.png",
                    Description = "Description for Brand 9",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 10",
                    LogoUrl = "https://example.com/logo10.png",
                    Description = "Description for Brand 10",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 11",
                    LogoUrl = "https://example.com/logo11.png",
                    Description = "Description for Brand 11",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 12",
                    LogoUrl = "https://example.com/logo12.png",
                    Description = "Description for Brand 12",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 13",
                    LogoUrl = "https://example.com/logo13.png",
                    Description = "Description for Brand 13",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 14",
                    LogoUrl = "https://example.com/logo14.png",
                    Description = "Description for Brand 14",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                },
                new BrandEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brand 15",
                    LogoUrl = "https://example.com/logo15.png",
                    Description = "Description for Brand 15",
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow
                }
            };

            return brands;
        }
    }
}