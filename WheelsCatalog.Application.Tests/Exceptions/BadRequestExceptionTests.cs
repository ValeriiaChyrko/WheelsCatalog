using NUnit.Framework;
using WheelsCatalog.Application.Common.Exceptions;

namespace WheelsCatalog.Application.Tests.Exceptions;

[TestFixture]
public class BadRequestExceptionTests
{
    [Test]
    public void Constructor_WithMessage_SetsMessage()
    {
        // Arrange
        const string expectedMessage = "Test message";
        
        // Act
        var exception = new BadRequestException(expectedMessage);
        
        // Assert
        Assert.That(exception.Message, Is.EqualTo(expectedMessage));
    }
    
    [Test]
    public void Constructor_WithErrors_SetsErrors()
    {
        // Arrange
        string[] errors = { "Error 1", "Error 2" };
        
        // Act
        var exception = new BadRequestException(errors);
        
        // Assert
        Assert.That(exception.Errors, Is.EqualTo(errors));
    }
    
    [Test]
    public void Constructor_WithErrors_SetsDefaultMessage()
    {
        // Arrange
        string[] errors = { "Error 1", "Error 2" };
        var expectedMessage = "Multiple errors occurred. See error details.";
        
        // Act
        var exception = new BadRequestException(errors);
        
        // Assert
        Assert.That(exception.Message, Is.EqualTo(expectedMessage));
    }
}