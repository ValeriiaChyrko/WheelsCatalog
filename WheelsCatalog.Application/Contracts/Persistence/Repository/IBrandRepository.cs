using WheelsCatalog.Application.Contracts.Persistence.Repository.Common;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Domain.BrandAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence.Repository;

public interface IBrandRepository : IGenericRepository<Domain.BrandAggregate.Brand>
{
    Task<ICollection<Brand>> GetAllByFilterAsync(int pageNumber, int pageSize,
        BrandFilteringParameters? filtering = null, CancellationToken cancellationToken = default);

    Task<int> CountWithFiltersAsync(BrandFilteringParameters? filtering = null,
        CancellationToken cancellationToken = default);
}