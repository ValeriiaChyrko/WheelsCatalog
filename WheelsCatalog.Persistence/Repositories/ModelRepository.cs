using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class ModelRepository : GenericRepository<Model, ModelEntityModel>, IModelRepository
{
    public ModelRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
}