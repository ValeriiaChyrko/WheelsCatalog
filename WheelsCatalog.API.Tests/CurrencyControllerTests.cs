using MediatR;
using Moq;
using WheelsCatalog.API.Controllers;
using WheelsCatalog.Application.Features.Currency.Queries.Requests;

namespace WheelsCatalog.API.Tests;

[TestFixture]
public class CurrencyControllerTests
{
    private CurrencyController _currencyController = null!;
    private Mock<IMediator> _mediatorMock = null!;

    [SetUp]
    public void Setup()
    {
        _mediatorMock = new Mock<IMediator>();
        _currencyController = new CurrencyController(_mediatorMock.Object);
    }
    
    [Test]
    public async Task Get_Calls_Mediator_With_Correct_Request()
    {
        // Act
        await _currencyController.Get();

        // Assert
        _mediatorMock.Verify(m => m.Send(It.IsAny<GetCurrencyDtoListRequest>(), default));
    }
    
    [Test]
    public async Task GetCurrenciesAmount_Calls_Mediator_With_Correct_Request()
    {
        // Act
        await _currencyController.GetAmount();

        // Assert
        _mediatorMock.Verify(m => m.Send(It.IsAny<GetCurrencyDtoListCountRequest>(), default));
    }

    [Test]
    public async Task GetCurrencyById_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _currencyController.Get(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetCurrencyDtoRequest>(request =>
            request.Id == id), default));
    }
}