using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Domain.PriceHistoryAggregate;

public sealed class PriceHistory : AggregateRoot<PriceHistoryId>
{
    public double Price { get; private set; }
    public DateTime StartDate { get; private set; }
    public CurrencyId CurrencyId { get; private set; }
    public CarId CarId { get; private set; }
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    private PriceHistory(PriceHistoryId id, double price, DateTime startDate, CurrencyId currencyId, CarId carId, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        Price = price;
        StartDate = startDate;
        CurrencyId = currencyId;
        CarId = carId;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static PriceHistory Create(double price, DateTime startDate, CurrencyId currencyId, CarId carId)
    {
        var priceHistoryId = PriceHistoryId.CreateUnique();
        var recordDateTime = DateTime.Now;
        
        var priceHistory = new PriceHistory(priceHistoryId, price, startDate, currencyId, carId, recordDateTime, recordDateTime);
        return priceHistory;
    }
    
    public void Update(double price, DateTime startDate, CurrencyId currencyId, CarId carId)
    {
        Price = price;
        StartDate = startDate;
        CurrencyId = currencyId;
        CarId = carId;
        UpdateDateTime = DateTime.Now;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public PriceHistory(CarId carId)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        CarId = carId;
    }
}