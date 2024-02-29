using NUnit.Framework;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;

namespace WheelsCatalog.Application.Tests.Exceptions;

[TestFixture]
public class NotFoundRequestExceptionTests
{

    [Test]
    public void Constructor_WithObjectId_SetsMessage()
    {
        // Arrange
        var objectId = Guid.NewGuid();
        var expectedMessage = $"Об'єкт з ідентифікатором '{objectId}' не знайдено в базі даних";

        // Act
        var exception = new NotFoundRequestException(new NotFoundError{ Entity = "Model", Id = objectId});

        // Assert
        Assert.That(exception.Message, Is.EqualTo(expectedMessage));
    }
}