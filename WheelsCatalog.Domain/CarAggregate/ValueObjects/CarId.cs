using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.CarAggregate.ValueObjects;

public sealed class CarId : ValueObject
{
    public Guid Value { get; }

    private CarId(Guid value)
    {
        Value = value;
    }
    
    public static CarId Create(Guid value)
    {
        return new CarId(value);
    }

    public static CarId CreateUnique()
    {
        return new CarId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
#pragma warning disable CS8618 
    private CarId() { }
#pragma warning restore CS8618
}