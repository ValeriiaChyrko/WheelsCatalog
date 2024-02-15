using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.Car.ValueObjects;

public sealed class CarId : ValueObject
{
    public Guid Value { get; }

    private CarId(Guid value)
    {
        Value = value;
    }

    public static CarId CreateUnique()
    {
        return new CarId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}