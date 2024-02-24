using WheelsCatalog.Application.Contracts.Persistence.Repository.Common;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Contracts.Persistence.Repository;

public interface ICarRepository : IGenericRepository<Car>
{
    Task<string?> GetCarModelNameAsync(ModelId modelId, CancellationToken cancellationToken = default);
    Task<string?> GetCarColorNameAsync(ColorId colorId, CancellationToken cancellationToken = default);

    Task<int> CountByModelIdAsync(ModelId modelId, CancellationToken cancellationToken = default);
    Task<ICollection<Car>> GetAllByModelIdAsync(ModelId modelId, CancellationToken cancellationToken = default);
    Task<ICollection<Car>> GetAllByModelIdAsync(int pageNumber, int pageSize, ModelId modelId, CancellationToken cancellationToken = default);

    Task<int> CountByColorIdAsync(ColorId colorId, CancellationToken cancellationToken = default);
    Task<ICollection<Car>> GetAllByColorIdAsync(ColorId colorId, CancellationToken cancellationToken = default);
    Task<ICollection<Car>> GetAllByColorIdAsync(int pageNumber, int pageSize, ColorId colorId, CancellationToken cancellationToken = default);

    Task<int> CountByModelIdsAsync(List<ModelId> modelIds, CancellationToken cancellationToken = default);
    Task<ICollection<Car>> GetAllByModelIdsAsync(List<ModelId> modelIds, CancellationToken cancellationToken = default);
    Task<ICollection<Car>> GetAllByModelIdsAsync(int pageNumber, int pageSize, List<ModelId> modelIds,
        CancellationToken cancellationToken = default);
}