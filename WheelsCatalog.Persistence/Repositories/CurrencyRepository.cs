using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Domain.CurrencyAggregate;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class CurrencyRepository : GenericRepository<Currency, CurrencyEntityModel>, ICurrencyRepository
{
    private readonly WheelsCatalogDbContext _context;

    public CurrencyRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
    }

    public string? GetCurrencyAcronym(CurrencyId priceHistoryId)
    {
        var currencyAcronym = _context.Set<CurrencyEntityModel>()
            .Where(currency => currency.Id == priceHistoryId.Value)
            .Select(currency => currency.Acronym)
            .FirstOrDefault();

        return currencyAcronym;
    }
}