using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Domain.CarAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;

public interface ICarRepository : IGenericRepository<Car>
{
    Task<string?> GetCarModelNameAsync(Guid modelId, CancellationToken cancellationToken = default);
    Task<string?> GetCarBrandNameAsync(Guid modelId, CancellationToken cancellationToken = default);
    Task<string?> GetCarColorNameAsync(Guid colorId, CancellationToken cancellationToken = default);

    Task<double?> GetCarDtoEngineVolumeMax();
    Task<double?> GetCarDtoEngineVolumeMin();
    
    Task<int> CountWithFiltersAsync(CarFilteringParameters? filtering = null,
        PriceFilteringParameters? priceFiltering = null,
        CancellationToken cancellationToken = default);

    Task<ICollection<Car>> GetAllByFilterAsync(int pageNumber, int pageSize,
        CarFilteringParameters? filtering = null, PriceFilteringParameters? priceFiltering = null,
        CancellationToken cancellationToken = default);
}