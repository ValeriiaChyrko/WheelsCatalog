using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class PriceHistoryRepository : GenericRepository<PriceHistory, PriceHistoryEntityModel>, IPriceHistoryRepository
{
    public PriceHistoryRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
}