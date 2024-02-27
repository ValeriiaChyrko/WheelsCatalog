using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Domain.ModelAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;

public interface IModelRepository : IGenericRepository<Model>
{
    Task<ICollection<Model>> GetAllByBrandIdAsync(Guid brandId, CancellationToken cancellationToken = default);
    Task<int> CountByBrandIdAsync(Guid brandId, CancellationToken cancellationToken = default);
    Task<ICollection<Model>> GetAllByBrandIdAsync(int pageNumber, int pageSize, Guid brandId, CancellationToken cancellationToken = default);

    Task<int> CountWithFiltersAsync(ModelFilteringParameters? filtering = null,
        CancellationToken cancellationToken = default);
    Task<ICollection<Model>> GetAllByFilterAsync(int pageNumber, int pageSize,
        ModelFilteringParameters? filtering = null, CancellationToken cancellationToken = default);
}