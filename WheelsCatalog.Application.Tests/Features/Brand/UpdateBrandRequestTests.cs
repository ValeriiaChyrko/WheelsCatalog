using FluentValidation.TestHelper;
using MediatR;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Application.Features.Brand.Commands.Requests.Validators;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Tests.Features.Brand;

[TestFixture]
public class UpdateBrandRequestTests
{
    [Test]
    public void UpdateBrandRequest_Id_Set_Get_Test()
    {
        // Arrange
        var id = Guid.NewGuid();
        var request = new UpdateBrandRequest { Id = id };

        // Act
        var result = request.Id;

        // Assert
        Assert.That(result, Is.EqualTo(id));
    }
    
    [Test]
    public void ImplementsIRequestOfBrandId()
    {
        // Arrange
        var request = new UpdateBrandRequest();
            
        // Assert
        Assert.That(request, Is.InstanceOf<IRequest<BrandId>>());
    }
    
    [Test]
    public void BrandDto_HasCorrectAccessibility()
    {
        // Arrange
        var propertyInfo = typeof(UpdateBrandRequest).GetProperty("BrandDto");
            
        // Assert
        Assert.That(propertyInfo!.CanRead);
        Assert.That(propertyInfo.CanWrite, Is.True);
    }

    [Test]
    public void UpdateBrandRequest_BrandDto_Set_Get_Test()
    {
        // Arrange
        var brandDto = new RequestBrandDto(); 
        var request = new UpdateBrandRequest { BrandDto = brandDto };

        // Act
        var result = request.BrandDto;

        // Assert
        Assert.That(result, Is.EqualTo(brandDto));
    }
    
    [Test]
    public void BrandDto_Should_Not_Be_Null()
    {
        // Arrange
        var validator = new UpdateBrandRequestValidator();
        var request = new UpdateBrandRequest { BrandDto = null };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.BrandDto)
            .WithErrorMessage("BrandDto must not be null.");
    }

    [Test]
    public void Id_Should_Not_Be_Empty()
    {
        // Arrange
        var validator = new UpdateBrandRequestValidator();
        var request = new UpdateBrandRequest { Id = Guid.Empty };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Id)
            .WithErrorMessage("Id must not be empty GUID.");
    }

    [Test]
    public void Id_Should_Not_Be_Null()
    {
        // Arrange
        var validator = new UpdateBrandRequestValidator();
        var request = new UpdateBrandRequest { Id = null };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Id)
            .WithErrorMessage("Id is required.");
    }

    [Test]
    public void Valid_Request_Should_Pass()
    {
        // Arrange
        var validator = new UpdateBrandRequestValidator();
        var request = new UpdateBrandRequest { Id = Guid.NewGuid(), 
            BrandDto = new RequestBrandDto
            {
                Name = "Test", Logo = new FileDto
                {
                    FileName = "logo.jpg",
                    ContentType = "image/jpeg",
                    Data = "%PDF"u8.ToArray()
                }
            } };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}