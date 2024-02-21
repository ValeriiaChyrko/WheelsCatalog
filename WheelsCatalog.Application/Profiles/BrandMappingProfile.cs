using AutoMapper;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.profiles;

public class BrandMappingProfile : Profile
{
    public BrandMappingProfile()
    {
        CreateMap<RequestBrandDto, Brand>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => BrandId.CreateUnique()))
            .ForMember(dest => dest.LogoUrl, opt => opt.Ignore());
        
        CreateMap<Brand, RespondBrandDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));
        
        CreateMap<Brand, RespondBrandDtoDetails>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));
    }
    
}
