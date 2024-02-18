using AutoMapper;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers;

public class ColorMapper : IEntityMapper<ColorEntity, ColorEntityModel>
{
    private readonly IMapper _mapper;

    public ColorMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public ColorEntityModel MapToModel(ColorEntity entity)
    {
        return _mapper.Map<ColorEntityModel>(entity);
    }

    public ColorEntity MapToEntity(ColorEntityModel model)
    {
        return _mapper.Map<ColorEntity>(model);
    }
}