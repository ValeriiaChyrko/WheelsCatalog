using WheelsCatalog.Application.Contracts.Persistence.Common;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Contracts.Persistence;

public interface ICarRepository : IGenericRepository<Car>
{
    public string? GetCarModelName(CarId carId);
    public string? GetCarColorName(CarId carId);
    Task<ICollection<Car>> GetAllByModelIdAsync(ModelId modelId, CancellationToken cancellationToken = default);
    Task<ICollection<Car>> GetAllByColorIdAsync(ColorId colorId, CancellationToken cancellationToken = default);
    Task<ICollection<Car>> GetAllByModelIdsAsync(List<ModelId> modelIds, CancellationToken cancellationToken = default);
}