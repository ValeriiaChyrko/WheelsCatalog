using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Tests.Validators;

[TestFixture]
public class RequestsDtosValidatorsTestsRequestCarDto
{
    private RequestCarDtoValidator _validator = null!;

    [SetUp]
    public void Setup()
    {
        _validator = new RequestCarDtoValidator();
    }

    [Test]
    public void Description_WhenEmpty_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { Description = "" });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Description"));
    }

    [Test]
    public void Description_WhenTooLong_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { Description = new string('x', 513) });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Description"));
    }

    [Test]
    public void Description_WhenValid_ShouldNotHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { Description = "Valid description" });
        Assert.IsFalse(result.Errors.Exists(e => e.PropertyName == "Description"));
    }

    [Test]
    public void Description_WhenNull_ShouldNotHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { Description = null });
        Assert.IsFalse(result.Errors.Exists(e => e.PropertyName == "Description"));
    }

    [Test]
    public void EngineVolume_WhenZero_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { EngineVolume = 0 });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "EngineVolume"));
    }

    [Test]
    public void EngineVolume_WhenNegative_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { EngineVolume = -1 });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "EngineVolume"));
    }

    [Test]
    public void EngineVolume_WhenInteger_ShouldNotHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { EngineVolume = 100 });
        Assert.IsFalse(result.Errors.Exists(e => e.PropertyName == "EngineVolume"));
    }

    [Test]
    public void ModelId_WhenEmpty_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { ModelId = Guid.Empty });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "ModelId"));
    }

    [Test]
    public void ModelId_WhenNull_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { ModelId = null });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "ModelId"));
    }

    [Test]
    public void ColorId_WhenEmpty_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { ColorId = Guid.Empty });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "ColorId"));
    }

    [Test]
    public void ColorId_WhenNull_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarDto { ColorId = null });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "ColorId"));
    }
}