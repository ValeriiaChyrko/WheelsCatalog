using WheelsCatalog.Application.Contracts.Persistence.Repository.Common;
using WheelsCatalog.Domain.CurrencyAggregate;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;

namespace WheelsCatalog.Application.Contracts.Persistence.Repository;

public interface ICurrencyRepository : IReadRepositoryBase<Currency>
{
    public string? GetCurrencyAcronym(CurrencyId priceHistoryId);
}