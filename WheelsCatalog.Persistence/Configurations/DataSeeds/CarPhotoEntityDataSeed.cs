using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class CarPhotoDataSeed
{
    internal static List<CarPhotoEntityModel> SeedCarPhotos(List<CarEntityModel> cars)
    {
        var random = new Random();
        var photos = new List<CarPhotoEntityModel>();

        foreach (var car in cars)
        {
            var numPhotos = random.Next(0, 5);

            for (var i = 0; i < numPhotos; i++)
                photos.Add(new CarPhotoEntityModel
                {
                    Id = Guid.NewGuid(),
                    PhotoUrl = $"https://example.com/photo{i + 1}.jpg",
                    CarId = car.Id
                });
        }

        return photos;
    }
}