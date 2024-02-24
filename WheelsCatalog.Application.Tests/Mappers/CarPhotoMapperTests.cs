using AutoMapper;
using Moq;
using NUnit.Framework;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Profiles;
using WheelsCatalog.Domain.CarAggregate.Entities;

namespace WheelsCatalog.Application.Tests.Mappers;

[TestFixture]
public class CarPhotoMapperTests
{
    private IMapper _mapper = null!;
    private Mock<IFileService> _fileServiceMock = null!;

    [SetUp]
    public void Setup()
    {
        _fileServiceMock = new Mock<IFileService>();
        _fileServiceMock.Setup(service => service.UploadImage(It.IsAny<FileDto>()))
            .ReturnsAsync("https://firebasestorage.googleapis.com/v0/b/wheelscatalog-564d8.appspot.com");
        
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
        Assert.IsFalse(string.IsNullOrEmpty(result.PhotoUrl));
        
        _fileServiceMock.Verify(service => service.UploadImage(It.IsAny<FileDto>()), Times.Once);
    }
}