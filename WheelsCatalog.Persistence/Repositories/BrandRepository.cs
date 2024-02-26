using System.Linq.Expressions;
using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
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
            filterCondition = filterCondition.And(model => model.Name.Contains(filtering.PartialName));

        return filterCondition;
    }

    public async Task<int> CountWithFiltersAsync(BrandFilteringParameters? filtering = null,
        CancellationToken cancellationToken = default)
    {
        var filterCondition = BuildFilterCondition(filtering);
        var count = await CountAsync(filterCondition, cancellationToken);
        return count;
    }

    public async Task<ICollection<Brand>> GetAllByFilterAsync(int pageNumber, int pageSize,
        BrandFilteringParameters? filtering = null, CancellationToken cancellationToken = default)
    {
        var filterCondition = BuildFilterCondition(filtering);
        var models = await ListAsync(pageNumber, pageSize, filterCondition, cancellationToken);
        return models;
    }
}