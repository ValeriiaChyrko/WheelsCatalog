using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.PriceHistory.Entities;
using WheelsCatalog.Domain.PriceHistory.ValueObjects;

namespace WheelsCatalog.Domain.PriceHistory;

public sealed class PriceHistoryAggregate : AggregateRoot<PriceHistoryId>
{
    public double Price { get; }
    public DateTime StartDate { get; }
    public CurrencyEntity CurrencyEntity { get; }
    public DateTime CreateDateTime { get; }
    public DateTime UpdateDateTime { get; }

    public PriceHistoryAggregate(PriceHistoryId id, double price, DateTime startDate, CurrencyEntity currencyEntity, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        Price = price;
        StartDate = startDate;
        CurrencyEntity = currencyEntity;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static PriceHistoryAggregate Create(double price, DateTime startDate, CurrencyEntity currencyEntity, DateTime createDateTime, DateTime updateDateTime)
    {
        return new PriceHistoryAggregate(PriceHistoryId.CreateUnique(), price, startDate, currencyEntity, createDateTime, updateDateTime);
    }
}