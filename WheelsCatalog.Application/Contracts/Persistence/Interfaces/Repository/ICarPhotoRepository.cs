using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;

public interface ICarPhotoRepository : IGenericRepository<CarPhotoEntity>
{
    Task<IEnumerable<CarPhotoEntity>> GetAllPhotosByCarId(CarId carId);
}