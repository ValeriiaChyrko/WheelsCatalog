using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.profiles;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate;

namespace WheelsCatalog.Application.Tests.Mappers;

[TestFixture]
public class ModelMapperTests
{
    private IMapper _mapper = null!;

    [SetUp]
    public void Setup()
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new ModelMappingProfile());
        });

        _mapper = mapperConfig.CreateMapper();
    }
    
    [Test]
    public void Map_RequestModelDto_To_Model()
    {
        // Arrange
        var modelDto = new RequestModelDto
        {
            Name = "Test Model",
            Description = "Test Description",
            BrandId = Guid.NewGuid()
        };
        
        // Act
        var result = _mapper.Map<Model>(modelDto);

        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Name, Is.EqualTo(modelDto.Name));
        Assert.That(result.Description, Is.EqualTo(modelDto.Description));
        Assert.That(result.BrandId.Value, Is.EqualTo(modelDto.BrandId));
    }
    
    [Test]
    public void Map_Model_To_RespondModelDto()
    {
        // Arrange
        var model = Model.Create("Test Model", "Test Description", BrandId.CreateUnique());
        
        // Act
        var result = _mapper.Map<RespondModelDto>(model);
    
        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Id, Is.EqualTo(model.Id.Value));
        Assert.That(result.Name, Is.EqualTo(model.Name));
        Assert.That(result.Description, Is.EqualTo(model.Description));
    }
}