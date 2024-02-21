using AutoMapper;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers.Profiles;

public class CarEntityModelMappingProfile : Profile
{
    public CarEntityModelMappingProfile()
    {
        CreateMap<Car, CarEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.ColorId, opt => opt.MapFrom(src => src.ColorId.Value))
            .ForMember(dest => dest.ModelId, opt => opt.MapFrom(src => src.ModelId.Value));

        CreateMap<CarEntityModel, Car>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => CarId.Create(src.Id)));
    }
}