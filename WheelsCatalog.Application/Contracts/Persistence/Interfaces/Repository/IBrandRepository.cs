using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Domain.BrandAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;

public interface IBrandRepository : IGenericRepository<Brand>
{
    Task<ICollection<Brand>> GetAllByFilterAsync(int? pageNumber, int? pageSize,
        BrandFilteringParameters? filtering = null, CancellationToken cancellationToken = default);

    Task<int> CountWithFiltersAsync(BrandFilteringParameters? filtering = null,
        CancellationToken cancellationToken = default);
}