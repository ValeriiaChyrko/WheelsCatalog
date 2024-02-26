using FluentValidation.TestHelper;
using MediatR;
using NUnit.Framework;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Application.Features.Model.Commands.Requests.Validators;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Application.Tests.Features.Model;

[TestFixture]
public class DeleteModelRequestTests
{
    [Test]
    public void Constructor_WithValidId_SetsIdCorrectly()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var request = new DeleteModelRequest { Id = id };

        // Assert
        That(request.Id, Is.EqualTo(id));
    }

    [Test]
    public void ImplementsIRequestOfModelId()
    {
        // Arrange
        var request = new DeleteModelRequest();

        // Assert
        That(request, Is.InstanceOf<IRequest<ModelId>>());
    }

    [Test]
    public void Id_HasCorrectAccessibility()
    {
        // Arrange
        var propertyInfo = typeof(DeleteModelRequest).GetProperty("Id");

        // Assert
        IsTrue(propertyInfo!.CanRead);
        IsTrue(propertyInfo.CanWrite);
    }

    [Test]
    public void Validate_ValidRequest_ShouldNotHaveErrors()
    {
        // Arrange
        var validator = new DeleteModelRequestValidator();
        var request = new DeleteModelRequest { Id = Guid.NewGuid() };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }

    [Test]
    public void Validate_NullId_ShouldHaveError()
    {
        // Arrange
        var validator = new DeleteModelRequestValidator();
        var request = new DeleteModelRequest { Id = null };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Id)
            .WithErrorMessage("Id is required.");
    }

    [Test]
    public void Validate_EmptyId_ShouldHaveError()
    {
        // Arrange
        var validator = new DeleteModelRequestValidator();
        var request = new DeleteModelRequest { Id = Guid.Empty };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Id)
            .WithErrorMessage("Id must not be empty GUID.");
    }
}