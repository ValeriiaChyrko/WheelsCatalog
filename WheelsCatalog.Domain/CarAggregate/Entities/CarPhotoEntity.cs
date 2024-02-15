using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.CarAggregate.Entities;

public class CarPhotoEntity : Entity<CarPhotoId>
{
    public string PhotoUrl { get; private set; }

    private CarPhotoEntity(CarPhotoId id, string photoUrl) : base(id)
    {
        PhotoUrl = photoUrl;
    }
    
    public static CarPhotoEntity Create(string photoUrl)
    {
        return new CarPhotoEntity(CarPhotoId.CreateUnique(), photoUrl);
    }
    
#pragma warning disable CS8618 
    private CarPhotoEntity() { }
#pragma warning restore CS8618
}