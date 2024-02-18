using AutoMapper;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers;

public class CarMapper : IEntityMapper<Car, CarEntityModel>
{
    private readonly IMapper _mapper;

    public CarMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public CarEntityModel MapToModel(Car entity)
    {
        return _mapper.Map<CarEntityModel>(entity);
    }

    public Car MapToEntity(CarEntityModel model)
    {
        return _mapper.Map<Car>(model);
    }
}