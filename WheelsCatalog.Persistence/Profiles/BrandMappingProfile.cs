using AutoMapper;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Profiles;

public class BrandMappingProfile : Profile
{
    public BrandMappingProfile()
    {
        CreateMap<Brand, BrandEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.Models, opt => opt.Ignore());

        CreateMap<BrandEntityModel, Brand>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => BrandId.Create(src.Id)));
    }
}