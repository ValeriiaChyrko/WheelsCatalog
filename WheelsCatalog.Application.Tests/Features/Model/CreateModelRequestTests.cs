using MediatR;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Application.Features.Model.Commands.Requests.Validators;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Tests.Features.Model;

[TestFixture]
public class CreateModelRequestTests
{
    [Test]
    public void CreateModelRequest_ModelDto_Property_Set_Get_Test()
    {
        // Arrange
        var modelDto = new RequestModelDto(); 
        var request = new CreateModelRequest { ModelDto = modelDto };

        // Act
        var result = request.ModelDto;

        // Assert
        Assert.That(result, Is.EqualTo(modelDto));
    }

    [Test]
    public void ImplementsIRequestOfBrandId()
    {
        // Arrange
        var request = new CreateModelRequest();
            
        // Assert
        Assert.That(request, Is.InstanceOf<IRequest<ModelId>>());
    }
    
    [Test]
    public void ModelDto_HasCorrectAccessibility()
    {
        // Arrange
        var propertyInfo = typeof(CreateModelRequest).GetProperty("ModelDto");
            
        // Assert
        Assert.That(propertyInfo!.CanRead);
        Assert.That(propertyInfo.CanWrite, Is.True);
    }
    
    [Test]
    public void Validate_ValidRequest_ReturnsNoErrors()
    {
        // Arrange
        var validator = new CreateModelRequestValidator();
        var request = new CreateModelRequest
        {
            ModelDto = new RequestModelDto
            {
                Name = "Test Model",
                Description = "Some description",
                BrandId = BrandId.CreateUnique().Value
            }
        };

        // Act
        var validationResult = validator.Validate(request);

        // Assert
        Assert.IsTrue(validationResult.IsValid);
    }

    [Test]
    public void Validate_InvalidRequest_ReturnsErrors()
    {
        // Arrange
        var validator = new CreateModelRequestValidator();
        var request = new CreateModelRequest { ModelDto = new RequestModelDto { Name = "", BrandId = Guid.Empty }};

        // Act
        var validationResult = validator.Validate(request);

        // Assert
        Assert.IsFalse(validationResult.IsValid);
        Assert.That(validationResult.Errors.Count, Is.EqualTo(2));
        Assert.That(validationResult.Errors[0].ErrorMessage, Is.EqualTo("Name is required."));
        Assert.That(validationResult.Errors[1].ErrorMessage, Is.EqualTo("Brand Id must not be empty GUID."));
    }
}