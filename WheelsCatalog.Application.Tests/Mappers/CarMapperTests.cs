using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.profiles;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Tests.Mappers;

[TestFixture]
public class CarMapperTests
{
    private IMapper _mapper = null!;

    [SetUp]
    public void Setup()
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new CarMappingProfile());
        });

        _mapper = mapperConfig.CreateMapper();
    }
    
    [Test]
    public void Map_RequestCarDto_To_Car()
    {
        // Arrange
        var carDto = new RequestCarDto
        {
            EngineVolume = 6700,
            Description = "Test Description",
            ModelId = Guid.NewGuid(),
            ColorId = Guid.NewGuid()
        };
        
        // Act
        var result = _mapper.Map<Car>(carDto);

        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.EngineVolume, Is.EqualTo(carDto.EngineVolume));
        Assert.That(result.Description, Is.EqualTo(carDto.Description));
        Assert.That(result.ModelId.Value, Is.EqualTo(carDto.ModelId));
        Assert.That(result.ColorId.Value, Is.EqualTo(carDto.ColorId));
    }
    
    [Test]
    public void Map_Car_To_RespondCarDto()
    {
        // Arrange
        var car = Car.Create(8000, "Test Description", ColorId.CreateUnique(), ModelId.CreateUnique());
        
        // Act
        var result = _mapper.Map<RespondCarDto>(car);
    
        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Id, Is.EqualTo(car.Id.Value));
        Assert.That(result.EngineVolume, Is.EqualTo(car.EngineVolume));
        Assert.That(result.Description, Is.EqualTo(car.Description));
    }
    
    [Test]
    public void Map_Car_To_RespondCarDtoDetails()
    {
        // Arrange
        var car = Car.Create(8000, "Test Description", ColorId.CreateUnique(), ModelId.CreateUnique());
        
        // Act
        var result = _mapper.Map<RespondCarDtoDetails>(car);
    
        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Id, Is.EqualTo(car.Id.Value));
        Assert.That(result.EngineVolume, Is.EqualTo(car.EngineVolume));
        Assert.That(result.Description, Is.EqualTo(car.Description));
    }
}