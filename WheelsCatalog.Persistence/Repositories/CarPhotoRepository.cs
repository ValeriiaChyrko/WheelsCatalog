using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class CarPhotoRepository : GenericRepository<CarPhotoEntity, CarPhotoEntityModel>, ICarPhotoRepository
{
    public CarPhotoRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
}