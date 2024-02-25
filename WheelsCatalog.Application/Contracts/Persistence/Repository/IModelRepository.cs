﻿using WheelsCatalog.Application.Contracts.Persistence.Repository.Common;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence.Repository;

public interface IModelRepository : IGenericRepository<Model>
{
    Task<ICollection<Model>> GetAllByBrandIdAsync(BrandId brandId, CancellationToken cancellationToken = default);
    Task<int> CountByBrandIdAsync(BrandId brandId, CancellationToken cancellationToken = default);
    Task<ICollection<Model>> GetAllByBrandIdAsync(int pageNumber, int pageSize, BrandId brandId, CancellationToken cancellationToken = default);
}