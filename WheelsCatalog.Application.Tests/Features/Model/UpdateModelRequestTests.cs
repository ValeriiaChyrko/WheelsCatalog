using FluentValidation.TestHelper;
using MediatR;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Application.Features.Model.Commands.Requests.Validators;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Tests.Features.Model;

[TestFixture]
public class UpdateModelRequestTests
{
    [Test]
    public void UpdateModelRequest_Id_Set_Get_Test()
    {
        // Arrange
        var id = Guid.NewGuid();
        var request = new UpdateModelRequest { Id = id };

        // Act
        var result = request.Id;

        // Assert
        Assert.That(result, Is.EqualTo(id));
    }
    
    [Test]
    public void ImplementsIRequestOfModelId()
    {
        // Arrange
        var request = new UpdateModelRequest();
            
        // Assert
        Assert.That(request, Is.InstanceOf<IRequest<ModelId>>());
    }
    
    [Test]
    public void ModelDto_HasCorrectAccessibility()
    {
        // Arrange
        var propertyInfo = typeof(UpdateModelRequest).GetProperty("ModelDto");
            
        // Assert
        Assert.That(propertyInfo!.CanRead);
        Assert.That(propertyInfo.CanWrite, Is.True);
    }

    [Test]
    public void UpdateModelRequest_ModelDto_Set_Get_Test()
    {
        // Arrange
        var modelDto = new RequestModelDto(); 
        var request = new UpdateModelRequest { ModelDto = modelDto };

        // Act
        var result = request.ModelDto;

        // Assert
        Assert.That(result, Is.EqualTo(modelDto));
    }
    
    [Test]
    public void ModelDto_Should_Not_Be_Null()
    {
        // Arrange
        var validator = new UpdateModelRequestValidator();
        var request = new UpdateModelRequest { ModelDto = null };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ModelDto)
            .WithErrorMessage("ModelDto must not be null.");
    }

    [Test]
    public void Id_Should_Not_Be_Empty()
    {
        // Arrange
        var validator = new UpdateModelRequestValidator();
        var request = new UpdateModelRequest { Id = Guid.Empty };

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
        var validator = new UpdateModelRequestValidator();
        var request = new UpdateModelRequest { Id = null };

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
        var validator = new UpdateModelRequestValidator();
        var request = new UpdateModelRequest { Id = Guid.NewGuid(), 
            ModelDto = new RequestModelDto
            {
                Name = "Test Model",
                Description = "Some description",
                BrandId = BrandId.CreateUnique().Value
            }};

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}