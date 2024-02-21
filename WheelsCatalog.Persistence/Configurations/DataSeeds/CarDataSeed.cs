using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds
{
    public static class CarDataSeed
    {
        internal static List<CarEntityModel> SeedCars(List<ModelEntityModel> models, List<ColorEntityModel> colors)
        {
            var cars = new List<CarEntityModel>();
            var random = new Random();

            for (var i = 0; i < 20; i++)
            {
                var modelId = models[random.Next(models.Count)].Id;
                var colorId = colors[random.Next(colors.Count)].Id;

                var engineVolume = random.Next(1000, 5000);
                var description = $"Description for car {i + 1}";
                var createDateTime = DateTime.UtcNow.AddDays(-random.Next(1, 365));
                var updateDateTime = createDateTime.AddHours(random.Next(1, 24));

                var car = new CarEntityModel
                {
                    Id = Guid.NewGuid(),
                    EngineVolume = engineVolume,
                    Description = description,
                    ColorId = colorId,
                    ModelId = modelId,
                    CreateDateTime = createDateTime,
                    UpdateDateTime = updateDateTime
                };

                cars.Add(car);
            }

            return cars;
        }
    }
}