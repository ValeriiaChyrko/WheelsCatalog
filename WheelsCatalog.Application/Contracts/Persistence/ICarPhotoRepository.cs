using WheelsCatalog.Application.Contracts.Persistence.Common;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Contracts.Persistence;

public interface ICarPhotoRepository : IGenericRepository<CarPhotoEntity>
{
    Task<IEnumerable<CarPhotoEntity>> GetAllPhotosByCarIdName(CarId carId);
}