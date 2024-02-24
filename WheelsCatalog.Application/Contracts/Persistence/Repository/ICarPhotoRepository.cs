using WheelsCatalog.Application.Contracts.Persistence.Repository.Common;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Contracts.Persistence.Repository;

public interface ICarPhotoRepository : IGenericRepository<CarPhotoEntity>
{
    Task<IEnumerable<CarPhotoEntity>> GetAllPhotosByCarIdName(CarId carId);
}