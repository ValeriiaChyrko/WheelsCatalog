using WheelsCatalog.Application.contracts.persistence;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

public class CarRepository : GenericRepository<Car, CarEntityModel>, ICarRepository
{
    public CarRepository(WheelsCatalogDbContext context, IEntityMapper<Car, CarEntityModel> mapper) : base(context, mapper)
    {
    }
    
}