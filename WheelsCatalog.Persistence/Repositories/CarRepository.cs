using System.Linq.Expressions;
using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class CarRepository : GenericRepository<Car, CarEntityModel>, ICarRepository
{
    private readonly WheelsCatalogDbContext _context;
    public CarRepository(WheelsCatalogDbContext context,IMapper mapper) : base(context, mapper)
    {
        _context = context;
    }
    
    public string? GetCarModelName(CarId carId)
    {
        var modelName = _context.Set<CarEntityModel>()
            .Where(car => car.Id == carId.Value)
            .Select(car => car.Model.Name)
            .FirstOrDefault();

        return modelName;
    }
    
    public string? GetCarColorName(CarId carId)
    {
        var modelName = _context.Set<CarEntityModel>()
            .Where(car => car.Id == carId.Value)
            .Select(car => car.Color.Name)
            .FirstOrDefault();

        return modelName;
    }

    public async Task<ICollection<Car>> GetAllByModelIdAsync(ModelId modelId, CancellationToken cancellationToken = default)
    {
        Expression<Func<Car, bool>> predicate = car => car.ModelId == modelId;
        var cars = await ListAsync(predicate, cancellationToken);

        return cars;
    }
    
    public async Task<ICollection<Car>> GetAllByModelIdsAsync(List<ModelId> modelIds, CancellationToken cancellationToken = default)
    {
        var targetGuids = modelIds.Select(id => id.Value).ToList();
        Expression<Func<Car, bool>> predicate = car => targetGuids.Contains(car.ModelId.Value);
        var cars = await ListAsync(predicate, cancellationToken);

        return cars;
    }
    
    public async Task<ICollection<Car>> GetAllByColorIdAsync(ColorId colorId, CancellationToken cancellationToken = default)
    {
        Expression<Func<Car, bool>> predicate = car => car.ColorId == colorId;
        var cars = await ListAsync(predicate, cancellationToken);

        return cars;
    }
}