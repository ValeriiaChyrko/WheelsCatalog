using WheelsCatalog.Application.contracts.persistence.common;
using WheelsCatalog.Domain.PriceHistoryAggregate;

namespace WheelsCatalog.Application.contracts.persistence;

public interface IPriceHistoryRepository : IGenericRepository<PriceHistory>
{

}