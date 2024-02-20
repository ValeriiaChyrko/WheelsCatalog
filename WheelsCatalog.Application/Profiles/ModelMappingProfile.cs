using AutoMapper;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Domain.ModelAggregate;

namespace WheelsCatalog.Application.profiles;

public class ModelMappingProfile : Profile
{
    public ModelMappingProfile()
    {
        CreateMap<ModelDto, Model>().ReverseMap();
    }
}