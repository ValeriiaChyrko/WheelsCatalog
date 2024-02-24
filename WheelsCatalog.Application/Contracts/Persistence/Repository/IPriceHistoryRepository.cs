﻿using WheelsCatalog.Application.Contracts.Persistence.Repository.Common;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence.Repository;

public interface IPriceHistoryRepository : IGenericRepository<PriceHistory>
{
    Task<ICollection<PriceHistory>> GetAllByCarIdAsync(CarId carId, CancellationToken cancellationToken = default);
    Task<PriceHistory?> GetActualPriceByCarIdAsync(CarId carId, CancellationToken cancellationToken = default);

    Task<PriceHistory?> GetActualPriceByCarIdStartByDateAsync(CarId carId, DateTime dateTime,
        CancellationToken cancellationToken = default);
}