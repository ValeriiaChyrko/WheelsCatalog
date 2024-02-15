using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

public class CurrencyId : ValueObject
{
    public Guid Value { get; }

    private CurrencyId(Guid value)
    {
        Value = value;
    }

    public static CurrencyId Create(Guid value)
    {
        return new CurrencyId(value);
    }
    
    public static CurrencyId CreateUnique()
    {
        return new CurrencyId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
#pragma warning disable CS8618 
    private CurrencyId() { }
#pragma warning restore CS8618
}