using WheelsCatalog.Application.Contracts.Persistence.Common;
using WheelsCatalog.Domain.PriceHistoryAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence;

public interface IPriceHistoryRepository : IGenericRepository<PriceHistory>
{

}