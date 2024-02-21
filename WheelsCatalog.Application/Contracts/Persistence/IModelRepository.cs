using WheelsCatalog.Application.Contracts.Persistence.Common;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence;

public interface IModelRepository : IGenericRepository<Model>
{
    Task<ICollection<Model>> GetAllByBrandIdAsync(BrandId brandId, CancellationToken cancellationToken = default);
}