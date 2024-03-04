using MediatR;
using Moq;
using WheelsCatalog.API.Controllers;
using WheelsCatalog.Application.Features.Color.Queries.Requests;

namespace WheelsCatalog.API.Tests;

[TestFixture]
public class ColorControllerTests
{
    private ColorController _colorController = null!;
    private Mock<IMediator> _mediatorMock = null!;

    [SetUp]
    public void Setup()
    {
        _mediatorMock = new Mock<IMediator>();
        _colorController = new ColorController(_mediatorMock.Object);
    }
    
    [Test]
    public async Task Get_Calls_Mediator_With_Correct_Request()
    {
        // Act
        await _colorController.Get();

        // Assert
        _mediatorMock.Verify(m => m.Send(It.IsAny<GetColorDtoListRequest>(), default));
    }
    
    [Test]
    public async Task GetColorsAmount_Calls_Mediator_With_Correct_Request()
    {
        // Act
        await _colorController.GetAmount();

        // Assert
        _mediatorMock.Verify(m => m.Send(It.IsAny<GetColorDtoListCountRequest>(), default));
    }

    [Test]
    public async Task GetColorById_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _colorController.Get(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetColorDtoRequest>(request =>
            request.Id == id), default));
    }
}