﻿using System.Linq.Expressions;
using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
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
            entity => entity.CarId == carId && entity.StartDate.Date <= dateTime.Date;

        var filteredEntities = await ListAsync(filterExpression, cancellationToken);
        var actualPrice = filteredEntities.MaxBy(entity => entity.StartDate.Date);

        return actualPrice;
    }
    
    public async Task<PriceHistory?> GetMaxPriceStartByDateAsync(DateTime? dateTime,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<PriceHistoryEntityModel, bool>> filterExpression =
            entity => entity.StartDate.Date <= (dateTime ?? DateTime.Now).Date;

        var filteredEntities = await ListAsync(true, price => price.Price, filterExpression, cancellationToken);
        return filteredEntities.FirstOrDefault();
    }
    
    public async Task<PriceHistory?> GetMinPriceStartByDateAsync(DateTime? dateTime,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<PriceHistoryEntityModel, bool>> filterExpression =
            entity => entity.StartDate.Date <= (dateTime ?? DateTime.Now).Date;

        var filteredEntities = await ListAsync(false, price => price.Price, filterExpression, cancellationToken);
        return filteredEntities.FirstOrDefault();
    }
}