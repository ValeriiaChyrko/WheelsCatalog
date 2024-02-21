using AutoMapper;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Domain.ColorAggregate;

namespace WheelsCatalog.Application.profiles;

public class ColorMappingProfile : Profile
{
    public ColorMappingProfile()
    {
        CreateMap<Color, RespondColorDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));
    }
    
}
