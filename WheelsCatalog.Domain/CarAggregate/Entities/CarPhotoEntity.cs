using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.CarAggregate.Entities;

public class CarPhotoEntity : Entity<CarPhotoId>
{
    public string PhotoUrl { get; private set; }
    public CarId CarId { get; private set; }

    private CarPhotoEntity(CarPhotoId id, string photoUrl, CarId carId) : base(id)
    {
        PhotoUrl = photoUrl;
        CarId = carId;
    }

    public static CarPhotoEntity Create(string photoUrl, CarId carId)
    {
        return new CarPhotoEntity(CarPhotoId.CreateUnique(), photoUrl, carId);
    }
    
    public void Update(string photoUrl, CarId carId)
    {
        PhotoUrl = photoUrl;
        CarId = carId;
    }


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public CarPhotoEntity(CarId carId)
    {
        CarId = carId;
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}