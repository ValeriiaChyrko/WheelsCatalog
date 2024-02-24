using AutoMapper;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Profiles;

public class PriceMappingProfile : Profile
{
    public PriceMappingProfile()
    {
        CreateMap<RequestPriceDto, PriceHistory>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => PriceHistoryId.CreateUnique()))
            .ForMember(dest=> dest.Price, opt=>opt.MapFrom(src=> src.Amount))
            .ForMember(dest=> dest.StartDate, opt=>opt.MapFrom(src=> src.Date))
            .ForMember(dest => dest.CarId, opt => opt.MapFrom(src => CarId.Create(src.CarId!.Value)))
            .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => CurrencyId.Create(src.CurrencyId!.Value)));

        CreateMap<PriceHistory, RespondPriceDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Price))
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.StartDate));
        
    }
}
