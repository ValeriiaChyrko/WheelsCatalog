using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Profiles;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate;

namespace WheelsCatalog.Application.Tests.Mappers;

[TestFixture]
public class PriceMapperTests
{
    private IMapper _mapper = null!;

    [SetUp]
    public void Setup()
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new PriceMappingProfile());
        });

        _mapper = mapperConfig.CreateMapper();
    }
    
    [Test]
    public void Map_RequestPriceDto_To_PriceHistory()
    {
        // Arrange
        var priceDto = new RequestPriceDto
        {
            Amount = 1000.50, 
            Date = DateTime.Now, 
            CurrencyId = Guid.NewGuid()
        };
        
        // Act
        var result = _mapper.Map<PriceHistory>(priceDto);

        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Price, Is.EqualTo(priceDto.Amount));
        Assert.That(result.StartDate, Is.EqualTo(priceDto.Date));
        Assert.That(result.CurrencyId.Value, Is.EqualTo(priceDto.CurrencyId));
    }
    
    [Test]
    public void Map_PriceHistory_To_RespondPriceDto()
    {
        // Arrange
        var price = PriceHistory.Create(1000, DateTime.Now, CurrencyId.CreateUnique(), CarId.CreateUnique());
        
        // Act
        var result = _mapper.Map<RespondPriceDto>(price);
    
        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Id, Is.EqualTo(price.Id.Value));
        Assert.That(result.Date, Is.EqualTo(price.StartDate));
    }
}