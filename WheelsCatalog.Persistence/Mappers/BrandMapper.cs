using AutoMapper;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers;

public class BrandMapper : IEntityMapper<Brand, BrandEntityModel>
{
    private readonly IMapper _mapper;

    public BrandMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public BrandEntityModel MapToModel(Brand entity)
    {
        return _mapper.Map<BrandEntityModel>(entity);
    }

    public Brand MapToEntity(BrandEntityModel model)
    {
        return _mapper.Map<Brand>(model);
    }
}
