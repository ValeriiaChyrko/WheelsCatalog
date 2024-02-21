using FluentValidation.TestHelper;
using NUnit.Framework;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.DTOs.sharedDtos.validators;

namespace WheelsCatalog.Application.Tests.Validators;

[TestFixture]
public class SharedDtosValidatorsTestsFileDto
{
    private FileDtoValidator _validator = null!;

    [SetUp]
    public void Initialize()
    {
        _validator = new FileDtoValidator();
    }

    [Test]
    public void Validate_ValidDto_ShouldNotHaveAnyValidationErrors()
    {
        // Arrange
        var validDto = new FileDto
        {
            FileName = "example-file.txt",
            ContentType = "text/plain",
            Data = new byte[] { 0x00, 0x01, 0x02 }
        };

        // Act
        var result = _validator.TestValidate(validDto);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }

    [Test]
    public void FileName_Should_NotBeEmpty()
    {
        // Arrange
        var dto = new FileDto { FileName = "", ContentType = "image/jpeg", Data = new byte[] { 0x00 } };

        // Act
        var result = _validator.TestValidate(dto);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.FileName)
            .WithErrorMessage("File Name is required.");
    }

    [Test]
    public void FileName_Should_NotExceedMaxLength()
    {
        // Arrange
        const int maxLength = 255;
        var fileName = new string('x', maxLength + 1);
        var dto = new FileDto { FileName = fileName, ContentType = "image/jpeg", Data = new byte[] { 0x00 } };

        // Act
        var result = _validator.TestValidate(dto);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.FileName)
            .WithErrorMessage($"File Name cannot be longer than {maxLength} characters.");
    }

    [Test]
    public void ContentType_Should_NotBeEmpty()
    {
        // Arrange
        var dto = new FileDto { FileName = "honda-logo", ContentType = "", Data = new byte[] { 0x00 } };

        // Act
        var result = _validator.TestValidate(dto);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ContentType)
            .WithErrorMessage("Content Type is required.");
    }

    [Test]
    public void ContentType_Should_NotExceedMaxLength()
    {
        // Arrange
        const int maxLength = 255;
        var contentType = new string('x', maxLength + 1);
        var dto = new FileDto { FileName = "honda-logo", ContentType = contentType, Data = new byte[] { 0x00 } };

        // Act
        var result = _validator.TestValidate(dto);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ContentType)
            .WithErrorMessage($"Content Type cannot be longer than {maxLength} characters.");
    }

    [Test]
    public void Data_Should_NotBeEmpty()
    {
        // Arrange
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var dto = new FileDto { FileName = "honda-logo", ContentType = "image/jpeg", Data = null };
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        // Act
        var result = _validator.TestValidate(dto);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Data)
            .WithErrorMessage("Data is required.");
    }

    [Test]
    public void Data_Should_Not_Be_Empty_When_Not_Null()
    {
        // Arrange
        var dto = new FileDto { FileName = "honda-logo", ContentType = "image/jpeg", Data = Array.Empty<byte>() };

        // Act
        var result = _validator.TestValidate(dto);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Data)
            .WithErrorMessage("Data cannot be empty.");
    }
}