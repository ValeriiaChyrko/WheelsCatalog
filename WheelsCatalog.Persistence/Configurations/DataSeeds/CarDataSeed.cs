using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class CarDataSeed
{
    public static List<Car> SeedCars(List<BrandId> brandIds, List<ModelId> modelIds, List<ColorId> colorIds, List<CarPhotoEntity> availablePhotos, List<PriceHistory> availablePriceHistories)
    {
        var cars = new List<Car>();

        var random = new Random();

        for (var i = 0; i < 20; i++)
        {
            var brandId = brandIds[random.Next(brandIds.Count)];
            var modelId = modelIds[random.Next(modelIds.Count)];
            var colorId = colorIds[random.Next(colorIds.Count)];

            var engineVolume = random.Next(1000, 5000);
            var description = $"Description for car {i + 1}";
            var createDateTime = DateTime.UtcNow.AddDays(-random.Next(1, 365));
            var updateDateTime = createDateTime.AddHours(random.Next(1, 24));

            var car = Car.Create(engineVolume, description, colorId, brandId, modelId, createDateTime, updateDateTime);
            
            var availablePhotosForCar = availablePhotos
                .Where(photo => !cars.Any(existingCar => existingCar.CarPhotoIds.Any(existingPhoto => existingPhoto.Id == photo.Id)))
                .ToList();
            
            var numEntitiesToAdd = random.Next(1, 3);
            for (var j = 0; j < numEntitiesToAdd && j < availablePhotosForCar.Count; j++)
            {
                var photo = availablePhotosForCar[j];
                car.AddPhoto(photo);
            }
            
            for (var j = 0; j < numEntitiesToAdd && j < availablePhotosForCar.Count; j++)
            {
                var priceHistory = availablePriceHistories[j];
                car.AddPriceHistory(priceHistory);
            }

            cars.Add(car);
        }

        return cars;
    }
}