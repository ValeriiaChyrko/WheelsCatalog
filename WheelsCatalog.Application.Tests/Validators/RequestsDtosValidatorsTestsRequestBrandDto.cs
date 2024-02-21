using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Tests.Validators;

[TestFixture]
public class RequestsDtosValidatorsTestsRequestBrandDto
{
    [TestFixture]
    public class RequestBrandDtoValidatorTests
    {
        private RequestBrandDtoValidator _validator = null!;

        [SetUp]
        public void Setup()
        {
            _validator = new RequestBrandDtoValidator();
        }

        [Test]
        public void Should_Have_Error_When_Name_Is_Null()
        {
            var result = _validator.Validate(new RequestBrandDto { Name = null });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Name"));
        }

        [Test]
        public void Should_Have_Error_When_Name_Is_Empty()
        {
            var result = _validator.Validate(new RequestBrandDto { Name = string.Empty });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Name"));
        }

        [Test]
        public void Should_Have_Error_When_Name_Exceeds_MaxLength()
        {
            var result = _validator.Validate(new RequestBrandDto { Name = new string('a', 256) });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Name"));
        }

        [Test]
        public void Should_Have_Error_When_Logo_Is_Null()
        {
            var result = _validator.Validate(new RequestBrandDto { Logo = null });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Logo"));
        }

        [Test]
        public void Should_Have_Error_When_Description_Exceeds_MaxLength()
        {
            var result = _validator.Validate(new RequestBrandDto { Description = new string('a', 513) });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Description"));
        }

        [Test]
        public void Should_Not_Have_Error_When_Description_Is_Null()
        {
            var result = _validator.Validate(new RequestBrandDto { Description = string.Empty });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Description"));
        }
    }
}