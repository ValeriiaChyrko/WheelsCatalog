using WheelsCatalog.Domain.Car.ValueObjects;
using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.Car.Entities;

public class CarPhotoEntity : Entity<CarPhotoId>
{
    public string PhotoUrl { get; }

    private CarPhotoEntity(CarPhotoId id, string photoUrl) : base(id)
    {
        PhotoUrl = photoUrl;
    }
    
    public static CarPhotoEntity Create(string photoUrl)
    {
        return new CarPhotoEntity(CarPhotoId.CreateUnique(), photoUrl);
    }
}