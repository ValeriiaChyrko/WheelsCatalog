using AutoMapper;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Domain.CurrencyAggregate;

namespace WheelsCatalog.Application.Profiles;

public class CurrencyMappingProfile : Profile
{
    public CurrencyMappingProfile()
    {
        CreateMap<Currency, RespondCurrencyDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));
    }
    
}
