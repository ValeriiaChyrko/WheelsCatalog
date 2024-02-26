using System.Linq.Expressions;
using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class ModelRepository : GenericRepository<Model, ModelEntityModel>, IModelRepository
{
    public ModelRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<int> CountByBrandIdAsync(Guid brandId, CancellationToken cancellationToken = default)
    {
        Expression<Func<ModelEntityModel, bool>> predicate = model => model.BrandId == brandId;
        var modelEntityByBrandCount = await CountAsync(predicate, cancellationToken);
        return modelEntityByBrandCount;
    }

    public async Task<ICollection<Model>> GetAllByBrandIdAsync(Guid brandId,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<ModelEntityModel, bool>> predicate = model => model.BrandId == brandId;
        var models = await ListAsync(predicate, cancellationToken);

        return models;
    }

    public async Task<ICollection<Model>> GetAllByBrandIdAsync(int pageNumber, int pageSize,
        Guid brandId, CancellationToken cancellationToken = default)
    {
        Expression<Func<ModelEntityModel, bool>> predicate = model => model.BrandId == brandId;
        var models = await ListAsync(pageNumber, pageSize, predicate, cancellationToken);

        return models;
    }

    private Expression<Func<ModelEntityModel, bool>> BuildFilterCondition(ModelFilteringParameters? filtering)
    {
        Expression<Func<ModelEntityModel, bool>> filterCondition = model => true;

        if (filtering?.PartialName != null)
            filterCondition = filterCondition.And(model => model.Name.Contains(filtering.PartialName));

        if (filtering?.BrandId != null)
            filterCondition = filterCondition.And(model => model.BrandId == filtering.BrandId.Value);

        return filterCondition;
    }

    public async Task<int> CountWithFiltersAsync(ModelFilteringParameters? filtering = null,
        CancellationToken cancellationToken = default)
    {
        var filterCondition = BuildFilterCondition(filtering);
        var count = await CountAsync(filterCondition, cancellationToken);
        return count;
    }

    public async Task<ICollection<Model>> GetAllByFilterAsync(int pageNumber, int pageSize,
        ModelFilteringParameters? filtering = null, CancellationToken cancellationToken = default)
    {
        var filterCondition = BuildFilterCondition(filtering);
        var models = await ListAsync(pageNumber, pageSize, filterCondition, cancellationToken);
        return models;
    }
}