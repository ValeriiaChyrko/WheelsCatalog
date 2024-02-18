using AutoMapper;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers.Profiles;

public class ModelMappingProfile : Profile
{
    public ModelMappingProfile()
    {
        CreateMap<Model, ModelEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.BrandId.Value))
            .ForMember(dest => dest.Brand, opt => opt.Ignore());

        CreateMap<ModelEntityModel, Model>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => ModelId.Create(src.Id)))
            .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => BrandId.Create(src.BrandId)));
    }
}