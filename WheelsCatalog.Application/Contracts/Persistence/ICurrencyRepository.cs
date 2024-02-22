using WheelsCatalog.Application.Contracts.Persistence.Common;
using WheelsCatalog.Domain.CurrencyAggregate;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;

namespace WheelsCatalog.Application.Contracts.Persistence;

public interface ICurrencyRepository : IReadRepositoryBase<Currency>
{
    public string? GetCurrencyAcronym(CurrencyId priceHistoryId);
}