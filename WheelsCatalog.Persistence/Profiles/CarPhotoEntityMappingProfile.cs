﻿using AutoMapper;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Profiles;

public class CarPhotoEntityMappingProfile : Profile
{
    public CarPhotoEntityMappingProfile()
    {
        CreateMap<CarPhotoEntity, CarPhotoEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value));

        CreateMap<CarPhotoEntityModel, CarPhotoEntity>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => CarPhotoId.Create(src.Id)));
    }
}