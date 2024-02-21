using AutoMapper;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.profiles;

public class CarMappingProfile : Profile
{
    public CarMappingProfile()
    {
        CreateMap<RequestCarDto, Car>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => CarId.CreateUnique()))
            .ForMember(dest => dest.ModelId, opt => opt.MapFrom(src => ModelId.Create(src.ModelId!.Value)))
            .ForMember(dest => dest.ColorId, opt => opt.MapFrom(src => ColorId.Create(src.ColorId!.Value)));

        CreateMap<Car, RespondCarDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));
        
        CreateMap<Car, RespondCarDtoDetails>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));
    }
}