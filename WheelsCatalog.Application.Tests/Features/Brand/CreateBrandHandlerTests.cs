using Moq;
using NUnit.Framework;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Handlers;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;

namespace WheelsCatalog.Application.Tests.Features.Brand;

[TestFixture]
public class CreateBrandHandlerTests
{
    private CreateBrandHandler _handler = null!;
    private Mock<IUnitOfWork> _mockBrandRepository = null!;
    private Mock<IFileService> _mockFileService = null!;

    [SetUp]
    public void SetUp()
    {
        _mockBrandRepository = new Mock<IUnitOfWork>();
        _mockFileService = new Mock<IFileService>();
        _handler = new CreateBrandHandler(_mockBrandRepository.Object, _mockFileService.Object);
    }

    [Test]
    public async Task Handle_ValidRequest_ShouldCreateBrandAndReturnId()
    {
        // Arrange
        var request = new CreateBrandRequest
        {
            BrandDto = new RequestBrandDto
            {
                Name = "Test", Logo = new FileDto
                {
                    FileName = "logo.jpg",
                    ContentType = "image/jpeg",
                    Data = "%PDF"u8.ToArray()
                }
            }
        };
        var logoUrl = $"htt" + $"p://example.com/logo.png";
        _mockFileService.Setup(x => x.UploadImage(It.IsAny<FileDto>())).ReturnsAsync(logoUrl);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        Assert.IsNotNull(result);
        _mockBrandRepository.Verify(x => x.BrandRepository.AddAsync(It.IsAny<Domain.BrandAggregate.Brand>(), CancellationToken.None), Times.Once);
    }

    [Test]
    public void Handle_UploadLogoFails_ThrowsOperationCanceledException()
    {
        // Arrange
        var request = new CreateBrandRequest
        {
            BrandDto = new RequestBrandDto
            {
                Name = "Test", Logo = new FileDto
                {
                    FileName = "logo.jpg",
                    ContentType = "image/jpeg",
                    Data = "%PDF"u8.ToArray()
                }
            }
        };
        _mockFileService.Setup(x => x.UploadImage(It.IsAny<FileDto>())).ReturnsAsync((string)null!);

        // Act & Assert
        Assert.ThrowsAsync<OperationCanceledException>(async () =>
            await _handler.Handle(request, CancellationToken.None));
        _mockBrandRepository.Verify(x => x.BrandRepository.AddAsync(It.IsAny<Domain.BrandAggregate.Brand>(), CancellationToken.None), Times.Never);
    }
}