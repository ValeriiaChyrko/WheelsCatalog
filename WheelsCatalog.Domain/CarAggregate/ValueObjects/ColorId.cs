using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.Car.ValueObjects;

public sealed class ColorId : ValueObject
{
    public Guid Value { get; }

    private ColorId(Guid value)
    {
        Value = value;
    }

    public static ColorId CreateUnique()
    {
        return new ColorId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}