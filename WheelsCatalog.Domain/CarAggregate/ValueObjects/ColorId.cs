using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.CarAggregate.ValueObjects;

public sealed class ColorId : ValueObject
{
    public Guid Value { get; }

    private ColorId(Guid value)
    {
        Value = value;
    }

    public static ColorId Create(Guid value)
    {
        return new ColorId(value);
    }
    
    public static ColorId CreateUnique()
    {
        return new ColorId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
#pragma warning disable CS8618 
    private ColorId() { }
#pragma warning restore CS8618
}