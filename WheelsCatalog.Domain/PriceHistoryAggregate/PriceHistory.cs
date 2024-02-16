using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Domain.PriceHistoryAggregate;

public sealed class PriceHistory : AggregateRoot<PriceHistoryId, Guid>
{
    public double Price { get; private set; }
    public DateTime StartDate { get; private set; }
    public CurrencyId CurrencyId { get; private set; }
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    public PriceHistory(PriceHistoryId id, double price, DateTime startDate, CurrencyId currencyId, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        Price = price;
        StartDate = startDate;
        CurrencyId = currencyId;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static PriceHistory Create(double price, DateTime startDate, CurrencyId currencyId, DateTime createDateTime, DateTime updateDateTime)
    {
        return new PriceHistory(PriceHistoryId.CreateUnique(), price, startDate, currencyId, createDateTime, updateDateTime);
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public PriceHistory()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }
}