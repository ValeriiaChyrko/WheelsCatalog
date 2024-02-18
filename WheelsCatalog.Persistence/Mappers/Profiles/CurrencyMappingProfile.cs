using AutoMapper;
using WheelsCatalog.Domain.PriceHistoryAggregate.Entities;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers.Profiles;

public class CurrencyMappingProfile : Profile
{
    public CurrencyMappingProfile()
    {
        CreateMap<CurrencyEntity, CurrencyEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));

        CreateMap<CurrencyEntityModel, CurrencyEntity>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => CurrencyId.Create(src.Id)));

    }
}