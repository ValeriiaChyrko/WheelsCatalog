using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.PriceHistory.ValueObjects;

public class PriceHistoryId : ValueObject
{
    public Guid Value { get; }

    private PriceHistoryId(Guid value)
    {
        Value = value;
    }

    public static PriceHistoryId CreateUnique()
    {
        return new PriceHistoryId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}