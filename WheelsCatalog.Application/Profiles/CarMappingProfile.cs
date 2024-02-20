using AutoMapper;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.CarAggregate;

namespace WheelsCatalog.Application.profiles;

public class CarMappingProfile : Profile
{
    public CarMappingProfile()
    {
        CreateMap<RequestCarDto, Car>().ReverseMap();
    }
}