using System.Linq.Expressions;
using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
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
        var models = await ListAsync(predicate, cancellationToken);

        return models;
    }
}