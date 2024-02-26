using System.Linq.Expressions;
using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class PriceHistoryRepository : GenericRepository<PriceHistory, PriceHistoryEntityModel>,
    IPriceHistoryRepository
{
    public PriceHistoryRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<PriceHistory>> GetAllByCarIdAsync(Guid carId,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<PriceHistoryEntityModel, bool>> predicate = car => car.CarId == carId;
        var priceHistories = await ListAsync(predicate, cancellationToken);

        return priceHistories;
    }

    public async Task<PriceHistory?> GetActualPriceByCarIdAsync(Guid carId,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<PriceHistoryEntityModel, bool>> filterExpression = entity => entity.CarId == carId;

        var filteredEntities = await ListAsync(filterExpression, cancellationToken);
        var actualPrice = filteredEntities.MaxBy(entity => entity.StartDate);

        return actualPrice;
    }

    public async Task<PriceHistory?> GetActualPriceByCarIdStartByDateAsync(Guid carId, DateTime dateTime,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<PriceHistoryEntityModel, bool>> filterExpression =
            entity => entity.CarId == carId && entity.StartDate >= dateTime;

        var filteredEntities = await ListAsync(filterExpression, cancellationToken);
        var actualPrice = filteredEntities.MinBy(entity => entity.StartDate);

        return actualPrice;
    }
}