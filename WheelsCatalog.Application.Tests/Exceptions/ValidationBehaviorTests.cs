using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Moq;
using NUnit.Framework;
using WheelsCatalog.Application.Behaviors;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Common.Exceptions;

namespace WheelsCatalog.Application.Tests.Exceptions;

[TestFixture]
    public class ValidationBehaviorTests
    {
        [Test]
        public async Task Handle_NoValidators_CallsNextDelegate()
        {
            // Arrange
            var behavior = new ValidationBehavior<TestRequest, TestResponse>(Enumerable.Empty<IValidator<TestRequest>>());
            var mockNext = new Mock<RequestHandlerDelegate<TestResponse>>();

            // Act
            await behavior.Handle(new TestRequest(), mockNext.Object, CancellationToken.None);

            // Assert
            mockNext.Verify(next => next(), Times.Once);
        }

        [Test]
        public async Task Handle_WithValidators_AllValidationsPass_CallsNextDelegate()
        {
            // Arrange
            var validatorMock = new Mock<IValidator<TestRequest>>();
            validatorMock.Setup(v => v.Validate(It.IsAny<ValidationContext<TestRequest>>()))
                         .Returns(new ValidationResult());

            var behavior = new ValidationBehavior<TestRequest, TestResponse>(new List<IValidator<TestRequest>> { validatorMock.Object });
            var mockNext = new Mock<RequestHandlerDelegate<TestResponse>>();

            // Act
            await behavior.Handle(new TestRequest(), mockNext.Object, CancellationToken.None);

            // Assert
            mockNext.Verify(next => next(), Times.Once);
        }

        [Test]
        public void Handle_WithValidators_ValidationFails_ThrowsBadRequestExceptionWithErrors()
        {
            // Arrange
            const string errorMessage1 = "Error 1";
            const string errorMessage2 = "Error 2";

            var validationResult = new ValidationResult(new List<ValidationFailure>
            {
                new("Property1", errorMessage1),
                new("Property2", errorMessage2)
            });

            var validatorMock = new Mock<IValidator<TestRequest>>();
            validatorMock.Setup(v => v.Validate(It.IsAny<ValidationContext<TestRequest>>()))
                         .Returns(validationResult);

            var behavior = new ValidationBehavior<TestRequest, TestResponse>(new List<IValidator<TestRequest>> { validatorMock.Object });

            // Act & Assert
            var exception = Assert.ThrowsAsync<BadRequestException>(() => behavior.Handle(new TestRequest(), null!, CancellationToken.None));
            Assert.That(exception!.Errors!.Length, Is.EqualTo(2));
            Assert.Contains(errorMessage1, exception.Errors);
            Assert.Contains(errorMessage2, exception.Errors);
        }
    }
    
    public class TestRequest : IRequest<TestResponse> { }
    public abstract class TestResponse { }