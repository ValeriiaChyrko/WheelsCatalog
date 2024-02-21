using AutoMapper;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.profiles;

public class CarPhotoMappingProfile : Profile
{
    public CarPhotoMappingProfile()
    {
        CreateMap<RequestCarPhotoDto, CarPhotoEntity>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => CarPhotoId.CreateUnique()))
            .ForMember(dest => dest.PhotoUrl, opt => opt.Ignore())
            .ForMember(dest => dest.CarId, opt => opt.MapFrom(src => CarId.Create(src.CarId!.Value)));
        
    }
}