using AutoMapper;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers.Profiles;

public class BrandEntityModelMappingProfile : Profile
{
    public BrandEntityModelMappingProfile()
    {
        CreateMap<Brand, BrandEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));

        CreateMap<BrandEntityModel, Brand>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => BrandId.Create(src.Id)));
    }
}