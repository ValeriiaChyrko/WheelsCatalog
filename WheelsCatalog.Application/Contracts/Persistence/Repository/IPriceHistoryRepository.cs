using WheelsCatalog.Application.Contracts.Persistence.Repository.Common;
using WheelsCatalog.Domain.PriceHistoryAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence.Repository;

public interface IPriceHistoryRepository : IGenericRepository<PriceHistory>
{
    Task<ICollection<PriceHistory>> GetAllByCarIdAsync(Guid carId, CancellationToken cancellationToken = default);
    Task<PriceHistory?> GetActualPriceByCarIdAsync(Guid carId, CancellationToken cancellationToken = default);

    Task<PriceHistory?> GetActualPriceByCarIdStartByDateAsync(Guid carId, DateTime dateTime,
        CancellationToken cancellationToken = default);
}