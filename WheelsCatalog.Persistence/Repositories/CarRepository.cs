using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class CarRepository : GenericRepository<Car, CarEntityModel>, ICarRepository
{
    public CarRepository(WheelsCatalogDbContext context,IMapper mapper) : base(context, mapper)
    {
    }
    
}