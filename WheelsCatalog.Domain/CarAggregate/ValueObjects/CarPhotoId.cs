using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.Car.ValueObjects;

public class CarPhotoId : ValueObject
{
    public Guid Value { get; }

    private CarPhotoId(Guid value)
    {
        Value = value;
    }

    public static CarPhotoId CreateUnique()
    {
        return new CarPhotoId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}