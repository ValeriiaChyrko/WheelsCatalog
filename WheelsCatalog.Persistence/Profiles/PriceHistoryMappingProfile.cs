using AutoMapper;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Profiles;

public class PriceHistoryMappingProfile : Profile
{
    public PriceHistoryMappingProfile()
    {
        CreateMap<PriceHistory, PriceHistoryEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId.Value));

        CreateMap<PriceHistoryEntityModel, PriceHistory>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => PriceHistoryId.Create(src.Id)))
            .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => CurrencyId.Create(src.CurrencyId)));
        
    }
}