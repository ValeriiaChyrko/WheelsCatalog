using AutoMapper;
using WheelsCatalog.Domain.PriceHistoryAggregate.Entities;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers;

public class CurrencyMapper : IEntityMapper<CurrencyEntity, CurrencyEntityModel>
{
    private readonly IMapper _mapper;

    public CurrencyMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public CurrencyEntityModel MapToModel(CurrencyEntity entity)
    {
        return _mapper.Map<CurrencyEntityModel>(entity);
    }

    public CurrencyEntity MapToEntity(CurrencyEntityModel model)
    {
        return _mapper.Map<CurrencyEntity>(model);
    }
}