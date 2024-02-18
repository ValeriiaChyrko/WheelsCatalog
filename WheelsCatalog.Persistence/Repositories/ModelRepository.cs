using WheelsCatalog.Application.contracts.persistence;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

public class ModelRepository : GenericRepository<Model, ModelEntityModel>, IModelRepository
{
    public ModelRepository(WheelsCatalogDbContext context, IEntityMapper<Model, ModelEntityModel> mapper) : base(context, mapper)
    {
    }
    
}