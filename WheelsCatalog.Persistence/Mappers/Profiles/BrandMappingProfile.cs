using AutoMapper;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers.Profiles;

public class BrandMappingProfile : Profile
{
    public BrandMappingProfile()
    {
        CreateMap<Brand, BrandEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.Models, opt => opt.MapFrom(src => src.ModelIds.Select(id => new ModelEntityModel { Id = id.Value })));

        CreateMap<BrandEntityModel, Brand>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => BrandId.Create(src.Id)))
            .AfterMap((src, dest) =>
            {
                foreach (var modelEntityModel in src.Models)
                {
                    dest.AddModelId(ModelId.Create(modelEntityModel.Id));
                }
            });
    }
}