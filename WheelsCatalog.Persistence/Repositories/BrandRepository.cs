using System.Linq.Expressions;
using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class BrandRepository : GenericRepository<Brand, BrandEntityModel>, IBrandRepository
{
    public BrandRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
    private Expression<Func<BrandEntityModel, bool>> BuildFilterCondition(BrandFilteringParameters? filtering)
    {
        Expression<Func<BrandEntityModel, bool>> filterCondition = model => true;

        if (filtering?.PartialName != null)
            filterCondition = filterCondition.And(brand => brand.Name.Contains(filtering.PartialName));

        return filterCondition;
    }
    
    private Expression<Func<BrandEntityModel, object>> BuildSortingCondition(BrandFilteringParameters? filtering)
    {
        Expression<Func<BrandEntityModel, object>> sortingCondition = brand => brand.Id;

        if (filtering?.SortPropertyName == null) return sortingCondition;
        
        var parameterExpression = Expression.Parameter(typeof(BrandEntityModel), "brand");
        var propertyExpression = Expression.PropertyOrField(parameterExpression, filtering.SortPropertyName);
        var convertExpression = Expression.Convert(propertyExpression, typeof(object)); 

        sortingCondition = Expression.Lambda<Func<BrandEntityModel, object>>(convertExpression, parameterExpression);
        return sortingCondition;
    }

    public async Task<int> CountWithFiltersAsync(BrandFilteringParameters? filtering = null,
        CancellationToken cancellationToken = default)
    {
        var filterCondition = BuildFilterCondition(filtering);
        var count = await CountAsync(filterCondition, cancellationToken);
        return count;
    }

    public async Task<ICollection<Brand>> GetAllByFilterAsync(int? pageNumber, int? pageSize,
        BrandFilteringParameters? filtering = null, CancellationToken cancellationToken = default)
    {
        var predicate = BuildFilterCondition(filtering);
        var sortExpression = BuildSortingCondition(filtering);
        var sortOrder = filtering?.IsDescending;
        var brands = await ListAsync(pageNumber, pageSize, sortOrder, sortExpression, predicate, cancellationToken);
        return brands;
    }
}