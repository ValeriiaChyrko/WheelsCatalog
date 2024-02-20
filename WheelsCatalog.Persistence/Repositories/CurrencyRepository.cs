using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.CurrencyAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class CurrencyRepository : GenericRepository<Currency, CurrencyEntityModel>, ICurrencyRepository
{
    public CurrencyRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
}