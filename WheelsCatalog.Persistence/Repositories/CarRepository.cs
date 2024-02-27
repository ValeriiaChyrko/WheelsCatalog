using System.Linq.Expressions;
using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class CarRepository : GenericRepository<Car, CarEntityModel>, ICarRepository
{
    public CarRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<string?> GetCarModelNameAsync(Guid modelId, CancellationToken cancellationToken = default)
    {
        var carEntityModel = await ListAsync(
            query => query.Where(car => car.ModelId == modelId),
            car => car.Model, 
            cancellationToken);

        return carEntityModel.FirstOrDefault()?.Model.Name;
    }
    
    public async Task<string?> GetCarBrandNameAsync(Guid modelId, CancellationToken cancellationToken = default)
    {
        var carEntityModel = await ListAsync(
            query => query.Where(car => car.Model.Id == modelId),
            car => car.Model.Brand, 
            cancellationToken);

        return carEntityModel.FirstOrDefault()?.Model.Brand.Name;
    }
    
    public async Task<string?> GetCarColorNameAsync(Guid colorId, CancellationToken cancellationToken = default)
    {
        var carEntityModel = await ListAsync(
            query => query.Where(car => car.ColorId == colorId),
            car => car.Color, 
            cancellationToken);

        return carEntityModel.FirstOrDefault()?.Color.Name;
    }
    
    public async Task<int> CountByModelIdAsync(Guid modelId,
        CancellationToken cancellationToken = default)
    {
        var carEntityModelCount = await CountAsync(carEntity => carEntity.ModelId == modelId, cancellationToken);
        return carEntityModelCount;
    }
    
    public async Task<ICollection<Car>> GetAllByModelIdAsync(int pageNumber, int pageSize, Guid modelId,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<CarEntityModel, bool>> predicate = car => car.ModelId == modelId;
        var cars = await ListAsync(pageNumber, pageSize, predicate, cancellationToken);

        return cars;
    }
    
    private Expression<Func<CarEntityModel, bool>> BuildFilterCondition(CarFilteringParameters? carFiltering,
        PriceFilteringParameters? priceFiltering)
    {
        Expression<Func<CarEntityModel, bool>> filterCondition = car => true;

        if (carFiltering?.ColorId != null)
            filterCondition = filterCondition.And(car => car.ColorId == carFiltering.ColorId);

        if (carFiltering?.ModelId != null)
            filterCondition = filterCondition.And(car => car.ModelId == carFiltering.ModelId);
        
        if (carFiltering?.PartialModelName != null)
            filterCondition = filterCondition.And(car => car.Model.Name.Contains(carFiltering.PartialModelName));
        
        if (carFiltering?.BrandId != null)
            filterCondition = filterCondition.And(car => car.Model.BrandId == carFiltering.BrandId);
        
        if (carFiltering?.PartialBrandName != null)
            filterCondition = filterCondition.And(car => car.Model.Brand.Name.Contains(carFiltering.PartialBrandName));
    
        if (carFiltering?.MinEngineVolume != null && carFiltering.MinEngineVolume != 0)
            filterCondition = filterCondition.And(car => car.EngineVolume.CompareTo(carFiltering.MinEngineVolume.Value) > 0);
        
        if (carFiltering?.MaxEngineVolume != null && carFiltering.MaxEngineVolume != 0)
            filterCondition = filterCondition.And(car => car.EngineVolume.CompareTo(carFiltering.MaxEngineVolume.Value) < 0);
        
        if (priceFiltering?.Date != null)
        {
            var targetDate = priceFiltering.Date.Value.Date;
            filterCondition = filterCondition.And(car => car.PriceHistories != null &&
                              car.PriceHistories.Any(ph => ph.StartDate <= targetDate));
        }

        if (priceFiltering?.MinPrice != null)
        {
            filterCondition = filterCondition.And(car => car.PriceHistories != null &&
                              car.PriceHistories.OrderByDescending(ph => ph.StartDate)
                              .FirstOrDefault(ph => ph.StartDate.Date <= (priceFiltering.Date ?? DateTime.Now).Date)!
                              .Price >= priceFiltering.MinPrice);
        }
        
        if (priceFiltering?.MaxPrice != null)
        {
            filterCondition = filterCondition.And(car => car.PriceHistories != null &&
                              car.PriceHistories.OrderByDescending(ph => ph.StartDate)
                              .FirstOrDefault(ph => ph.StartDate.Date <= (priceFiltering.Date ?? DateTime.Now).Date)!
                              .Price <= priceFiltering.MaxPrice);
        }

        return filterCondition;
    }

    private Expression<Func<CarEntityModel, object>> BuildSortingCondition(CarFilteringParameters? filtering)
    {
        Expression<Func<CarEntityModel, object>> sortingCondition = car => car.Id;

        if (filtering?.SortPropertyName == null) return sortingCondition;
        
        var parameterExpression = Expression.Parameter(typeof(CarEntityModel), "car");
        var propertyExpression = Expression.PropertyOrField(parameterExpression, filtering.SortPropertyName);
        var convertExpression = Expression.Convert(propertyExpression, typeof(object)); 

        sortingCondition = Expression.Lambda<Func<CarEntityModel, object>>(convertExpression, parameterExpression);
        return sortingCondition;
    }
    
    public async Task<int> CountWithFiltersAsync(CarFilteringParameters? filtering = null, 
        PriceFilteringParameters? priceFiltering = null,
        CancellationToken cancellationToken = default)
    {
        var filterCondition = BuildFilterCondition(filtering, priceFiltering);
        var count = await CountAsync(filterCondition, cancellationToken);
        return count;
    }

    public async Task<ICollection<Car>> GetAllByFilterAsync(int pageNumber, int pageSize,
        CarFilteringParameters? filtering = null, PriceFilteringParameters? priceFiltering = null,
        CancellationToken cancellationToken = default)
    {
        var predicate = BuildFilterCondition(filtering, priceFiltering);
        var sortExpression = BuildSortingCondition(filtering);
        var sortOrder = filtering?.IsDescending;
        var brands = await ListAsync(pageNumber, pageSize, sortOrder, sortExpression, predicate, cancellationToken);
        return brands;
    }
}