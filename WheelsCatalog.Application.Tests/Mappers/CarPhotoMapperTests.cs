using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Profiles;
using WheelsCatalog.Domain.CarAggregate.Entities;

namespace WheelsCatalog.Application.Tests.Mappers;

[TestFixture]
public class CarPhotoMapperTests
{
    private IMapper _mapper = null!;

    [SetUp]
    public void Setup()
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new CarPhotoMappingProfile());
        });

        _mapper = mapperConfig.CreateMapper();
    }
    
    [Test]
    public void Map_RequestCarPhotoDto_To_CarPhotoEntity()
    {
        // Arrange
        var photoData = "%PDF"u8.ToArray(); // Example file data
        var fileDto = new FileDto
        {
            FileName = "logo.jpg",
            ContentType = "image/jpeg",
            Data = photoData
        };
        var requestCarPhotoDto = new RequestCarPhotoDto
        {
            Photo = fileDto,
            CarId = Guid.NewGuid()
        };
        
        // Act
        var result = _mapper.Map<CarPhotoEntity>(requestCarPhotoDto);

        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.CarId.Value, Is.EqualTo(requestCarPhotoDto.CarId.Value));
    }
}