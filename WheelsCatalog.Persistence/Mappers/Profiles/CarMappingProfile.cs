using AutoMapper;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Mappers.Profiles;

public class CarMappingProfile : Profile
{
    public CarMappingProfile()
    {
        CreateMap<Car, CarEntityModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.ColorId, opt => opt.MapFrom(src => src.ColorId.Value))
            .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.BrandId.Value))
            .ForMember(dest => dest.ModelId, opt => opt.MapFrom(src => src.ModelId.Value))
            .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.CarPhotoIds.Select(id => new CarPhotoEntityModel { Id = id.Value })))
            .ForMember(dest => dest.PriceHistories, opt => opt.MapFrom(src => src.PriceHistoryIds.Select(id => new PriceHistoryEntityModel { Id = id.Value })));

        CreateMap<CarEntityModel, Car>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => CarId.Create(src.Id)))
            .AfterMap((src, dest) =>
            {
                if (src.Photos == null) return;
                foreach (var photoEntityModel in src.Photos)
                {
                    dest.AddPhotoId(CarPhotoId.Create(photoEntityModel.Id));
                }
                if (src.PriceHistories == null) return;
                foreach (var priceHistoryModel in src.Photos)
                {
                    dest.AddPriceHistory(PriceHistoryId.Create(priceHistoryModel.Id));
                }
            });
    }
}