using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class CarRepository : GenericRepository<Car, CarEntityModel>, ICarRepository
{
    private readonly WheelsCatalogDbContext _context;
    public CarRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
    }

    public async Task<string?> GetCarModelNameAsync(ModelId modelId, CancellationToken cancellationToken = default)
    {
        var carEntityModel = await ListAsync(
            query => query.Where(car => car.ModelId == modelId.Value),
            car => car.Model, 
            cancellationToken);

        return carEntityModel.FirstOrDefault()?.Model.Name;
    }
    
    public async Task<string?> GetCarColorNameAsync(ColorId colorId, CancellationToken cancellationToken = default)
    {
        var carEntityModel = await ListAsync(
            query => query.Where(car => car.ColorId == colorId.Value),
            car => car.Color, 
            cancellationToken);

        return carEntityModel.FirstOrDefault()?.Color.Name;
    }
    
    public async Task<int> CountByModelIdAsync(ModelId modelId,
        CancellationToken cancellationToken = default)
    {
        var carEntityModelCount = await CountAsync(carEntity => carEntity.ModelId == modelId.Value, cancellationToken);
        return carEntityModelCount;
    }

    public async Task<ICollection<Car>> GetAllByModelIdAsync(ModelId modelId,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<Car, bool>> predicate = car => car.ModelId == modelId;
        var cars = await ListAsync(predicate, cancellationToken);

        return cars;
    }
    
    public async Task<ICollection<Car>> GetAllByModelIdAsync(int pageNumber, int pageSize, ModelId modelId,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<Car, bool>> predicate = car => car.ModelId == modelId;
        var cars = await ListAsync(pageNumber, pageSize, predicate, cancellationToken);

        return cars;
    }

    public async Task<int> CountByModelIdsAsync(IEnumerable<ModelId> modelIds, CancellationToken cancellationToken = default)
    {
        var targetGuids = modelIds.Select(id => id.Value).ToList();
        Expression<Func<CarEntityModel, bool>> predicate = carEntity => targetGuids.Contains(carEntity.ModelId);

        return await CountAsync(predicate, cancellationToken);
    }

    
    public async Task<ICollection<Car>> GetAllByModelIdsAsync(IEnumerable<ModelId> modelIds,
        CancellationToken cancellationToken = default)
    {
        var targetGuids = modelIds.Select(id => id.Value).ToList();
        Expression<Func<Car, bool>> predicate = car => targetGuids.Contains(car.ModelId.Value);
        var cars = await ListAsync(predicate, cancellationToken);

        return cars;
    }

    public async Task<ICollection<Car>> GetAllByModelIdsAsync(int pageNumber, int pageSize, IEnumerable<ModelId> modelIds,
        CancellationToken cancellationToken = default)
    {
        var targetGuids = modelIds.Select(id => id.Value).ToList();
        Expression<Func<Car, bool>> predicate = car => targetGuids.Contains(car.ModelId.Value);
        var cars = await ListAsync(pageNumber, pageSize, predicate, cancellationToken);

        return cars;
    }
    
    public async Task<int> CountByColorIdAsync(ColorId colorId,
        CancellationToken cancellationToken = default)
    {
        var carEntityModelCount = await CountAsync(carEntity => carEntity.ColorId == colorId.Value, cancellationToken);
        return carEntityModelCount;
    }
    
    public async Task<ICollection<Car>> GetAllByColorIdAsync(ColorId colorId,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<Car, bool>> predicate = car => car.ColorId == colorId;
        return await ListAsync(predicate, cancellationToken);
    }
    
    public async Task<ICollection<Car>> GetAllByColorIdAsync(int pageNumber, int pageSize, ColorId colorId,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<Car, bool>> predicate = car => car.ColorId == colorId;
        return await ListAsync(pageNumber, pageSize, predicate, cancellationToken);
    }
    
    public async Task<int> CountByPriceFiltersAsync(DateTime dateTime, double minPrice, double maxPrice,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<PriceHistoryEntityModel, bool>> pricePredicate = 
            ph => ph.StartDate.Date <= dateTime.Date && ph.Price >= minPrice && ph.Price <= maxPrice;
        var carIdsInPriceRange = await _context.Set<PriceHistoryEntityModel>()
            .Where(pricePredicate)
            .Select(ph => ph.CarId)
            .Distinct()
            .ToListAsync(cancellationToken);
        
        var carsByPriceAmount = await CountAsync(car => carIdsInPriceRange.Contains(car.Id), cancellationToken);
        return carsByPriceAmount;
    }
    
    public async Task<ICollection<Car>?> GetAllByPriceIdAsync(int pageNumber, int pageSize, DateTime dateTime, 
        double minPrice, double maxPrice, CancellationToken cancellationToken = default)
    {
        Expression<Func<PriceHistoryEntityModel, bool>> pricePredicate = 
            ph => ph.StartDate.Date <= dateTime.Date && ph.Price >= minPrice && ph.Price <= maxPrice;

        var carIdsInPriceRange = await _context.Set<PriceHistoryEntityModel>()
            .Where(pricePredicate)
            .Select(ph => ph.CarId)
            .Distinct()
            .ToListAsync(cancellationToken);
        
        Expression<Func<Car, bool>> carPredicate = car => carIdsInPriceRange.Contains(car.Id.Value);
        var carsInPriceRange = await ListAsync(pageNumber, pageSize, carPredicate, cancellationToken);
        return carsInPriceRange;
    }
}