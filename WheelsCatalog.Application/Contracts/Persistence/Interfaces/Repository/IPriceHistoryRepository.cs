using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Domain.PriceHistoryAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;

public interface IPriceHistoryRepository : IGenericRepository<PriceHistory>
{
    Task<ICollection<PriceHistory>> GetAllByCarIdAsync(Guid carId, CancellationToken cancellationToken = default);
    Task<PriceHistory?> GetActualPriceByCarIdAsync(Guid carId, CancellationToken cancellationToken = default);

    Task<PriceHistory?> GetActualPriceByCarIdStartByDateAsync(Guid carId, DateTime dateTime,
        CancellationToken cancellationToken = default);

    Task<PriceHistory?> GetMaxPriceStartByDateAsync(DateTime? dateTime,
        CancellationToken cancellationToken = default);

    Task<PriceHistory?> GetMinPriceStartByDateAsync(DateTime? dateTime,
        CancellationToken cancellationToken = default);
}