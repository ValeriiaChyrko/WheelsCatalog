using AutoMapper;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers.Profiles;

public class CarPhotoEntityModelMappingProfile : Profile
{
    public CarPhotoEntityModelMappingProfile()
    {
        CreateMap<CarPhotoEntity, CarPhotoEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.CarId, opt => opt.MapFrom(src => src.CarId.Value));

        CreateMap<CarPhotoEntityModel, CarPhotoEntity>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => CarPhotoId.Create(src.Id)));
    }
}