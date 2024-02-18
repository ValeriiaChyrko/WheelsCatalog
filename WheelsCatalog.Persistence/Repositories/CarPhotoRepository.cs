using WheelsCatalog.Application.contracts.persistence;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

public class CarPhotoRepository : GenericRepository<CarPhotoEntity, CarPhotoEntityModel>, ICarPhotoRepository
{
    public CarPhotoRepository(WheelsCatalogDbContext context, IEntityMapper<CarPhotoEntity, CarPhotoEntityModel> mapper) : base(context, mapper)
    {
    }
    
}