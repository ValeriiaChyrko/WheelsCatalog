using FluentValidation.TestHelper;
using MediatR;
using NUnit.Framework;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Application.Features.Brand.Commands.Requests.Validators;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Application.Tests.Features.Brand;

[TestFixture]
public class DeleteBrandRequestTests
{
    [Test]
    public void Constructor_WithValidId_SetsIdCorrectly()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var request = new DeleteBrandRequest { Id = id };

        // Assert
        That(request.Id, Is.EqualTo(id));
    }

    [Test]
    public void ImplementsIRequestOfBrandId()
    {
        // Arrange
        var request = new DeleteBrandRequest();

        // Assert
        That(request, Is.InstanceOf<IRequest<BrandId>>());
    }

    [Test]
    public void Id_HasCorrectAccessibility()
    {
        // Arrange
        var propertyInfo = typeof(DeleteBrandRequest).GetProperty("Id");

        // Assert
        IsTrue(propertyInfo!.CanRead);
        IsTrue(propertyInfo.CanWrite);
    }

    [Test]
    public void Validate_ValidRequest_ShouldNotHaveErrors()
    {
        // Arrange
        var validator = new DeleteBrandRequestValidator();
        var request = new DeleteBrandRequest { Id = Guid.NewGuid() };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }

    [Test]
    public void Validate_NullId_ShouldHaveError()
    {
        // Arrange
        var validator = new DeleteBrandRequestValidator();
        var request = new DeleteBrandRequest { Id = null };

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
        var validator = new DeleteBrandRequestValidator();
        var request = new DeleteBrandRequest { Id = Guid.Empty };

        // Act
        var result = validator.TestValidate(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Id)
            .WithErrorMessage("Id must not be empty GUID.");
    }
}