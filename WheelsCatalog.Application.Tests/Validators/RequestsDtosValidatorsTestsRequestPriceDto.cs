using NUnit.Framework;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Tests.Validators;

[TestFixture]
public class RequestsDtosValidatorsTestsRequestPriceDto
{
    private RequestPriceDtoValidator _validator = null!;

        [SetUp]
        public void Setup()
        {
            _validator = new RequestPriceDtoValidator();
        }

        [Test]
        public void Amount_GreaterThanZero_Valid()
        {
            var result = _validator.Validate(new RequestPriceDto { Amount = 10 });
            Assert.IsFalse(result.Errors.Exists(e => e.PropertyName == "Amount"));
        }

        [Test]
        public void Amount_Zero_Invalid()
        {
            var result = _validator.Validate(new RequestPriceDto { Amount = 0 });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Amount"));
        }

        [Test]
        public void Date_NotEmpty_Valid()
        {
            var result = _validator.Validate(new RequestPriceDto { Date = DateTime.Now });
            Assert.IsFalse(result.Errors.Exists(e => e.PropertyName == "Date"));
        }

        [Test]
        public void Date_Empty_Invalid()
        {
            var result = _validator.Validate(new RequestPriceDto { Date = null });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "Date"));
        }

        [Test]
        public void CurrencyId_WhenEmpty_ShouldHaveValidationError()
        {
            var result = _validator.Validate(new RequestPriceDto { CurrencyId = Guid.Empty });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "CurrencyId"));
        }

        [Test]
        public void CurrencyId_WhenNull_ShouldHaveValidationError()
        {
            var result = _validator.Validate(new RequestPriceDto { CurrencyId = null });
            Assert.IsTrue(result.Errors.Exists(e => e.PropertyName == "CurrencyId"));
        }
}