using Moq;
using NUnit.Framework;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Handlers;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;

namespace WheelsCatalog.Application.Tests.Features.Brand;

[TestFixture]
public class UpdateBrandHandlerTests
{
    private UpdateBrandHandler _handler = null!;
    private Mock<IUnitOfWork> _mockBrandRepository = null!;
    private Mock<IFileService> _mockFileService = null!;

    [SetUp]
    public void SetUp()
    {
        _mockBrandRepository = new Mock<IUnitOfWork>();
        _mockFileService = new Mock<IFileService>();
        _handler = new UpdateBrandHandler(_mockBrandRepository.Object, _mockFileService.Object);
    }

    [Test]
    public async Task Handle_ValidRequest_ShouldUpdateBrandAndReturnId()
    {
        // Arrange
        var brand = Domain.BrandAggregate.Brand.Create("Test Brand", "https://example.com/logo.jpg", "Test Description");
        var request = new UpdateBrandRequest
        {
            Id = brand.Id.Value,
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
        _mockBrandRepository.Setup(x => x.BrandRepository.GetByIdAsync(brand.Id.Value, CancellationToken.None)).ReturnsAsync(brand);
        var logoUrl = $"http:/" + $"/example.com/updated_logo.png";
        _mockFileService.Setup(x => x.UploadImage(It.IsAny<FileDto>())).ReturnsAsync(logoUrl);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        Assert.That(result, Is.EqualTo(brand.Id));
        Assert.That(brand.Name, Is.EqualTo(request.BrandDto.Name));
        Assert.That(brand.Description, Is.EqualTo(request.BrandDto.Description));
        Assert.That(brand.LogoUrl, Is.EqualTo(logoUrl));
        _mockBrandRepository.Verify(x => x.BrandRepository.UpdateAsync(brand, CancellationToken.None), Times.Once);
    }

    [Test]
    public void Handle_BrandNotFound_ThrowsNotFoundRequestException()
    {
        // Arrange
        var brand = Domain.BrandAggregate.Brand.Create("Test Brand", "https://example.com/logo.jpg", "Test Description");
        var request = new UpdateBrandRequest { Id = brand.Id.Value };
        _mockBrandRepository.Setup(x => x.BrandRepository.GetByIdAsync(brand.Id.Value, CancellationToken.None))
            .ReturnsAsync((Domain.BrandAggregate.Brand)null!);

        // Act & Assert
        Assert.ThrowsAsync<NotFoundRequestException>(async () =>
            await _handler.Handle(request, CancellationToken.None));
        _mockBrandRepository.Verify(x => x.BrandRepository.UpdateAsync(It.IsAny<Domain.BrandAggregate.Brand>(), CancellationToken.None), Times.Never);
    }

    [Test]
    public void Handle_UploadLogoFails_ThrowsOperationCanceledException()
    {
        // Arrange
        var brand = Domain.BrandAggregate.Brand.Create("Test Brand", "https://example.com/logo.jpg", "Test Description");
        var request = new UpdateBrandRequest
        {
            Id = brand.Id.Value,
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
        _mockBrandRepository.Setup(x => x.BrandRepository.GetByIdAsync(brand.Id.Value, CancellationToken.None)).ReturnsAsync(brand);
        _mockFileService.Setup(x => x.UploadImage(It.IsAny<FileDto>())).ReturnsAsync((string)null!);

        // Act & Assert
        Assert.ThrowsAsync<OperationCanceledException>(async () =>
            await _handler.Handle(request, CancellationToken.None));
        _mockBrandRepository.Verify(x => x.BrandRepository.UpdateAsync(It.IsAny<Domain.BrandAggregate.Brand>(), CancellationToken.None), Times.Never);
    }
}