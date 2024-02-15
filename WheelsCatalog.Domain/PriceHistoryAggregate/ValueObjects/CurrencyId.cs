using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.PriceHistory.ValueObjects;

public class CurrencyId : ValueObject
{
    public Guid Value { get; }

    private CurrencyId(Guid value)
    {
        Value = value;
    }

    public static CurrencyId CreateUnique()
    {
        return new CurrencyId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}