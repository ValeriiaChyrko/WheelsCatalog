using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.CarAggregate.ValueObjects;

public class CarPhotoId : ValueObject
{
    public Guid Value { get; }

    private CarPhotoId(Guid value)
    {
        Value = value;
    }
    
    public static CarPhotoId Create(Guid value)
    {
        return new CarPhotoId(value);
    }

    public static CarPhotoId CreateUnique()
    {
        return new CarPhotoId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
#pragma warning disable CS8618 
    private CarPhotoId() { }
#pragma warning restore CS8618
}