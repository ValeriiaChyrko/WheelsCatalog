using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.BrandAggregate.ValueObjects;

public sealed class BrandId : ValueObject
{
    public Guid Value { get; }

    private BrandId(Guid value) 
    {
        Value = value;
    }

    public static BrandId Create(Guid value)
    {
        return new BrandId(value);
    }
    
    public static BrandId CreateUnique()
    {
        return new BrandId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
#pragma warning disable CS8618 
    private BrandId() { }
#pragma warning restore CS8618
}