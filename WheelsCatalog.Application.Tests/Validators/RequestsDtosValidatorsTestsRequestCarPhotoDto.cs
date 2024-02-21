using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Tests.Validators;

[TestFixture]
public class RequestsDtosValidatorsTestsRequestCarPhotoDto
{
    private RequestCarPhotoDtoValidator _validator = null!;

    [SetUp]
    public void Setup()
    {
        _validator = new RequestCarPhotoDtoValidator();
    }

    [Test]
    public void CarId_WhenEmpty_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarPhotoDto { CarId = Guid.Empty });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "CarId"));
    }

    [Test]
    public void CarId_WhenNull_ShouldHaveValidationError()
    {
        var result = _validator.Validate(new RequestCarPhotoDto { CarId = null });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "CarId"));
    }
    
    [Test]
    public void Should_Have_Error_When_Logo_Is_Null()
    {
        var result = _validator.Validate(new RequestCarPhotoDto { Photo = null });
        Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Photo"));
    }
}