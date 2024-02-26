﻿using WheelsCatalog.Application.Contracts.Persistence.Repository.Common;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Domain.CarAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence.Repository;

public interface ICarRepository : IGenericRepository<Car>
{
    Task<string?> GetCarModelNameAsync(Guid modelId, CancellationToken cancellationToken = default);
    Task<string?> GetCarBrandNameAsync(Guid modelId, CancellationToken cancellationToken = default);
    Task<string?> GetCarColorNameAsync(Guid colorId, CancellationToken cancellationToken = default);

    Task<int> CountByModelIdAsync(Guid modelId, CancellationToken cancellationToken = default);
    Task<ICollection<Car>> GetAllByModelIdAsync(int pageNumber, int pageSize, Guid modelId, CancellationToken cancellationToken = default);

    Task<int> CountWithFiltersAsync(CarFilteringParameters? filtering = null,
        PriceFilteringParameters? priceFiltering = null,
        CancellationToken cancellationToken = default);

    Task<ICollection<Car>> GetAllByFilterAsync(int pageNumber, int pageSize,
        CarFilteringParameters? filtering = null, PriceFilteringParameters? priceFiltering = null,
        CancellationToken cancellationToken = default);
}