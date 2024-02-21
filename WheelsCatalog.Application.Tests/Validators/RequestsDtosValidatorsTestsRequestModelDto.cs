using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Tests.Validators;

[TestFixture]
public class RequestsDtosValidatorsTestsRequestModelDto
{
    private RequestModelDtoValidator _validator = null!;

        [SetUp]
        public void Setup()
        {
            _validator = new RequestModelDtoValidator();
        }

        [Test]
        public void Should_Have_Error_When_Name_Is_Null()
        {
            var result = _validator.Validate(new RequestModelDto { Name = null });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Name"));
        }

        [Test]
        public void Should_Have_Error_When_Name_Is_Empty()
        {
            var result = _validator.Validate(new RequestModelDto { Name = string.Empty });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Name"));
        }

        [Test]
        public void Should_Have_Error_When_Name_Exceeds_MaxLength()
        {
            var result = _validator.Validate(new RequestModelDto { Name = new string('a', 256) });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Name"));
        }

        [Test]
        public void Should_Have_Error_When_Description_Exceeds_MaxLength()
        {
            var result = _validator.Validate(new RequestModelDto { Description = new string('a', 513) });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Description"));
        }

        [Test]
        public void Should_Not_Have_Error_When_Description_Is_Null()
        {
            var result = _validator.Validate(new RequestModelDto { Description = string.Empty });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Description"));
        }
        
        [Test]
        public void BrandId_WhenEmpty_ShouldHaveValidationError()
        {
            var result = _validator.Validate(new RequestModelDto { BrandId = Guid.Empty });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "BrandId"));
        }

        [Test]
        public void BrandId_WhenNull_ShouldHaveValidationError()
        {
            var result = _validator.Validate(new RequestModelDto { BrandId = null });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "BrandId"));
        }
}