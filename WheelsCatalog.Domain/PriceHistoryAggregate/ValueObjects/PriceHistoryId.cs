using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

public class PriceHistoryId : ValueObject
{
    public Guid Value { get; }

    private PriceHistoryId(Guid value)
    {
        Value = value;
    }

    public static PriceHistoryId Create(Guid value)
    {
        return new PriceHistoryId(value);
    }
    
    public static PriceHistoryId CreateUnique()
    {
        return new PriceHistoryId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
#pragma warning disable CS8618 
    private PriceHistoryId() { }
#pragma warning restore CS8618
}