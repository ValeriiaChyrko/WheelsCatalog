using AutoMapper;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers;

public class CarPhotoMapper : IEntityMapper<CarPhotoEntity, CarPhotoEntityModel>
{
    private readonly IMapper _mapper;

    public CarPhotoMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public CarPhotoEntityModel MapToModel(CarPhotoEntity entity)
    {
        return _mapper.Map<CarPhotoEntityModel>(entity);
    }

    public CarPhotoEntity MapToEntity(CarPhotoEntityModel model)
    {
        return _mapper.Map<CarPhotoEntity>(model);
    }
}