using System.Linq.Expressions;
using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class ModelRepository : GenericRepository<Model, ModelEntityModel>, IModelRepository
{
    public ModelRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Model>> GetAllByBrandIdAsync(BrandId brandId,
        CancellationToken cancellationToken = default)
    {
        Expression<Func<Model, bool>> predicate = model => model.BrandId == brandId;
        var models = await ListAsync(predicate, cancellationToken);

        return models;
    }
}