using AutoMapper;
using WheelsCatalog.Domain.CurrencyAggregate;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers.Profiles;

public class CurrencyMappingProfile : Profile
{
    public CurrencyMappingProfile()
    {
        CreateMap<Currency, CurrencyEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));

        CreateMap<CurrencyEntityModel, Currency>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => CurrencyId.Create(src.Id)));

    }
}