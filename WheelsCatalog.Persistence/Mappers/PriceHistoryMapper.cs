using AutoMapper;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers;

public class PriceHistoryMapper : IEntityMapper<PriceHistory, PriceHistoryEntityModel>
{
    private readonly IMapper _mapper;

    public PriceHistoryMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public PriceHistoryEntityModel MapToModel(PriceHistory entity)
    {
        return _mapper.Map<PriceHistoryEntityModel>(entity);
    }

    public PriceHistory MapToEntity(PriceHistoryEntityModel model)
    {
        return _mapper.Map<PriceHistory>(model);
    }
}