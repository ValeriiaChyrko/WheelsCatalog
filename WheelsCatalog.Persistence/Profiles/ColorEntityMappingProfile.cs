using AutoMapper;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Profiles;

public class ColorEntityMappingProfile : Profile
{
    public ColorEntityMappingProfile()
    {
        CreateMap<ColorEntity, ColorEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));

        CreateMap<ColorEntityModel, ColorEntity>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => ColorId.Create(src.Id)));

    }
}