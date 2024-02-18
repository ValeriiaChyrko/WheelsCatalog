using WheelsCatalog.Application.contracts.persistence;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

public class ColorRepository : GenericRepository<ColorEntity, ColorEntityModel>, IColorRepository
{
    public ColorRepository(WheelsCatalogDbContext context, IEntityMapper<ColorEntity, ColorEntityModel> mapper) : base(context, mapper)
    {
    }
    
}