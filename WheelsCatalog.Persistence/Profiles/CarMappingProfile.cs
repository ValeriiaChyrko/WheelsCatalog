using AutoMapper;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Profiles;

public class CarMappingProfile : Profile
{
    public CarMappingProfile()
    {
        CreateMap<Car, CarEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.ColorId, opt => opt.MapFrom(src => src.ColorId.Value))
            .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.BrandId.Value))
            .ForMember(dest => dest.ModelId, opt => opt.MapFrom(src => src.ModelId.Value))
            .ForMember(dest => dest.Photos, opt => opt.Ignore())
            .ForMember(dest => dest.PriceHistories, opt => opt.Ignore());

        CreateMap<CarEntityModel, Car>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => CarId.Create(src.Id)));
    }
}