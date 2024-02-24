using AutoMapper;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Profiles;

public class ModelMappingProfile : Profile
{
    public ModelMappingProfile()
    {
        CreateMap<RequestModelDto, Model>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => ModelId.CreateUnique()))
            .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => BrandId.Create(src.BrandId!.Value)));
        
        CreateMap<RespondModelDto, Model>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => ModelId.CreateUnique()));
        
        CreateMap<Model, RespondModelDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));
    }
}