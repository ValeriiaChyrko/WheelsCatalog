using WheelsCatalog.Domain.CarAggregate.Entities;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class CarPhotoEntityDataSeed
{
    public static List<CarPhotoEntity> SeedCarPhotos()
    {
        var carPhotos = new List<CarPhotoEntity>
        {
            CarPhotoEntity.Create("https://example.com/photo1.jpg"),
            CarPhotoEntity.Create("https://example.com/photo2.jpg"),
            CarPhotoEntity.Create("https://example.com/photo3.jpg"),
            CarPhotoEntity.Create("https://example.com/photo4.jpg"),
            CarPhotoEntity.Create("https://example.com/photo5.jpg")
        };

        return carPhotos;
    }
}