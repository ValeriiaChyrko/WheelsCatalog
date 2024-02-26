using Moq;
using NUnit.Framework;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Brand.Commands.Handlers;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Tests.Features.Brand;

[TestFixture]
public class DeleteBrandHandlerTests
{
    private DeleteBrandHandler _handler = null!;
    private Mock<IBrandRepository> _mockBrandRepository = null!;

    [SetUp]
    public void SetUp()
    {
        _mockBrandRepository = new Mock<IBrandRepository>();
        _handler = new DeleteBrandHandler(_mockBrandRepository.Object);
    }

    [Test]
    public async Task Handle_ValidRequest_ShouldDeleteBrandAndReturnId()
    {
        // Arrange
        var brand = Domain.BrandAggregate.Brand.Create("Test Brand", "https://example.com/logo.jpg", "Test Description");
        var request = new DeleteBrandRequest { Id = brand.Id.Value };
        _mockBrandRepository.Setup(x => x.GetByIdAsync(brand.Id.Value, CancellationToken.None)).ReturnsAsync(brand);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        Assert.That(result, Is.EqualTo(brand.Id));
        _mockBrandRepository.Verify(x => x.DeleteAsync(brand, CancellationToken.None), Times.Once);
    }

    [Test]
    public void Handle_InvalidId_ThrowsNotFoundRequestException()
    {
        // Arrange
        var brandId = BrandId.CreateUnique();
        var request = new DeleteBrandRequest { Id = brandId.Value };
        _mockBrandRepository.Setup(x => x.GetByIdAsync(brandId.Value, CancellationToken.None)).ReturnsAsync((Domain.BrandAggregate.Brand)null!);

        // Act & Assert
        Assert.ThrowsAsync<NotFoundRequestException>(async () => await _handler.Handle(request, CancellationToken.None));
        _mockBrandRepository.Verify(x => x.DeleteAsync(It.IsAny<Domain.BrandAggregate.Brand>(), CancellationToken.None), Times.Never);
    }
}