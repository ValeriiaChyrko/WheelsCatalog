using AutoMapper;
using WheelsCatalog.Domain.ColorAggregate;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers.Profiles;

public class ColorEntityModelMappingProfile : Profile
{
    public ColorEntityModelMappingProfile()
    {
        CreateMap<Color, ColorEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));

        CreateMap<ColorEntityModel, Color>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => ColorId.Create(src.Id)));
    }
}
