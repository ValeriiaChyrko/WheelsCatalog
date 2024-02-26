using MediatR;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Application.Features.Brand.Commands.Requests.Validators;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Application.Tests.Features.Brand;

[TestFixture]
public class CreateBrandRequestTests
{
    [Test]
    public void Constructor_WithValidDto_SetsBrandDtoCorrectly()
    {
        // Arrange
        var requestDto = new RequestBrandDto();
            
        // Act
        var request = new CreateBrandRequest { BrandDto = requestDto };
            
        // Assert
        That(request.BrandDto, Is.EqualTo(requestDto));
    }

    [Test]
    public void ImplementsIRequestOfBrandId()
    {
        // Arrange
        var request = new CreateBrandRequest();
            
        // Assert
        That(request, Is.InstanceOf<IRequest<BrandId>>());
    }

    [Test]
    public void BrandDto_HasCorrectAccessibility()
    {
        // Arrange
        var propertyInfo = typeof(CreateBrandRequest).GetProperty("BrandDto");
            
        // Assert
        That(propertyInfo!.CanRead);
        That(propertyInfo.CanWrite, Is.True);
    }
    
    [Test]
    public void Validate_ValidRequest_ReturnsNoErrors()
    {
        // Arrange
        var validator = new CreateBrandRequestValidator();
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

        // Act
        var validationResult = validator.Validate(request);

        // Assert
        IsTrue(validationResult.IsValid);
    }

    [Test]
    public void Validate_InvalidRequest_ReturnsErrors()
    {
        // Arrange
        var validator = new CreateBrandRequestValidator();
        var request = new CreateBrandRequest { BrandDto = new RequestBrandDto { Name = "" } };

        // Act
        var validationResult = validator.Validate(request);

        // Assert
        IsFalse(validationResult.IsValid);
        That(validationResult.Errors.Count, Is.EqualTo(2));
        That(validationResult.Errors[0].ErrorMessage, Is.EqualTo("Name is required."));
        That(validationResult.Errors[1].ErrorMessage, Is.EqualTo("Logo is required."));
    }
}