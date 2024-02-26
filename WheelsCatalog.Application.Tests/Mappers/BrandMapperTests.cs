using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Profiles;
using WheelsCatalog.Domain.BrandAggregate;

namespace WheelsCatalog.Application.Tests.Mappers;

[TestFixture]
public class BrandMapperTests
{
    private IMapper _mapper = null!;

    [SetUp]
    public void Setup()
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new BrandMappingProfile());
        });

        _mapper = mapperConfig.CreateMapper();
    }
    
    [Test]
    public void Map_RequestBrandDto_To_Brand()
    {
        // Arrange
        var logoData = "%PDF"u8.ToArray(); // Example file data
        var logoDto = new FileDto
        {
            FileName = "logo.jpg",
            ContentType = "image/jpeg",
            Data = logoData
        };
        var requestBrandDto = new RequestBrandDto
        {
            Name = "Test Brand",
            Logo = logoDto,
            Description = "Test Description"
        };
        
        // Act
        var result = _mapper.Map<Brand>(requestBrandDto);

        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Name, Is.EqualTo(requestBrandDto.Name));
        Assert.That(result.Description, Is.EqualTo(requestBrandDto.Description));
    }
    
    [Test]
    public void Map_Brand_To_RespondBrandDto()
    {
        // Arrange
        var brand = Brand.Create("Test Brand", "https://example.com/logo.jpg", "Test Description");
        
        // Act
        var result = _mapper.Map<RespondBrandDto>(brand);
    
        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Id, Is.EqualTo(brand.Id.Value));
        Assert.That(result.Name, Is.EqualTo(brand.Name));
        Assert.That(result.LogoUrl, Is.EqualTo(brand.LogoUrl));
        Assert.That(result.Description, Is.EqualTo(brand.Description));
    }
    
    [Test]
    public void Map_Brand_To_RespondBrandDtoDetails()
    {
        // Arrange
        var brand = Brand.Create("Test Brand", "https://example.com/logo.jpg", "Test Description");
        
        // Act
        var result = _mapper.Map<RespondBrandDtoDetails>(brand);
    
        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Id, Is.EqualTo(brand.Id.Value));
        Assert.That(result.Name, Is.EqualTo(brand.Name));
        Assert.That(result.LogoUrl, Is.EqualTo(brand.LogoUrl));
        Assert.That(result.Description, Is.EqualTo(brand.Description));
    }
}