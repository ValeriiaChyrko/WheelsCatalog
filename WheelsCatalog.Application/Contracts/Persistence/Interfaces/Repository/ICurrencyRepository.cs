using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Domain.CurrencyAggregate;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;

namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;

public interface ICurrencyRepository : IReadRepositoryBase<Currency>
{
    public string? GetCurrencyAcronym(CurrencyId priceHistoryId);
}