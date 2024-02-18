using WheelsCatalog.Application.contracts.persistence;
using WheelsCatalog.Domain.PriceHistoryAggregate.Entities;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

public class CurrencyRepository : GenericRepository<CurrencyEntity, CurrencyEntityModel>, ICurrencyRepository
{
    public CurrencyRepository(WheelsCatalogDbContext context, IEntityMapper<CurrencyEntity, CurrencyEntityModel> mapper) : base(context, mapper)
    {
    }
    
}