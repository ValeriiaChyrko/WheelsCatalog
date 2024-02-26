using NUnit.Framework;
using WheelsCatalog.Application.Common.Exceptions;

namespace WheelsCatalog.Application.Tests.Exceptions;

[TestFixture]
public class NotFoundRequestExceptionTests
{
    [Test]
    public void Constructor_WithMessage_SetsMessage()
    {
        // Arrange
        const string expectedMessage = "Test message";

        // Act
        var exception = new NotFoundRequestException(expectedMessage);

        // Assert
        Assert.That(exception.Message, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Constructor_WithObjectId_SetsMessage()
    {
        // Arrange
        var objectId = Guid.NewGuid();
        var expectedMessage = $"Object with id: {objectId} was not found in database";

        // Act
        var exception = new NotFoundRequestException(objectId);

        // Assert
        Assert.That(exception.Message, Is.EqualTo(expectedMessage));
    }
}