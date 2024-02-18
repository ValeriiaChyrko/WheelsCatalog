using WheelsCatalog.Application.contracts.persistence;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

public class PriceHistoryRepository : GenericRepository<PriceHistory, PriceHistoryEntityModel>, IPriceHistoryRepository
{
    public PriceHistoryRepository(WheelsCatalogDbContext context, IEntityMapper<PriceHistory, PriceHistoryEntityModel> mapper) : base(context, mapper)
    {
    }
    
}