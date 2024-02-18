using AutoMapper;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers;

public class ModelMapper : IEntityMapper<Model, ModelEntityModel>
{
    private readonly IMapper _mapper;

    public ModelMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public ModelEntityModel MapToModel(Model entity)
    {
        return _mapper.Map<ModelEntityModel>(entity);
    }

    public Model MapToEntity(ModelEntityModel model)
    {
        return _mapper.Map<Model>(model);
    }
}