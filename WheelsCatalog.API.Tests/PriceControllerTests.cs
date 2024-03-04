using MediatR;
using Moq;
using WheelsCatalog.API.Controllers;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;
using WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

namespace WheelsCatalog.API.Tests;

[TestFixture]
public class PriceControllerTests
{
    private PriceController _priceController = null!;
    private Mock<IMediator> _mediatorMock = null!;

    [SetUp]
    public void Setup()
    {
        _mediatorMock = new Mock<IMediator>();
        _priceController = new PriceController(_mediatorMock.Object);
    }
    
    [Test]
    public async Task GetMaxPrice_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var date = DateTime.Today;

        // Act
        await _priceController.GetMaxPrice(date);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetMaxPriceRequest>(request =>
            request.Date == date), default));
    }
    
    [Test]
    public async Task GetMinPrice_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var date = DateTime.Today;

        // Act
        await _priceController.GetMinPrice(date);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetMinPriceRequest>(request =>
            request.Date == date), default));
    }
    
    [Test]
    public async Task GetPriceByCarId_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _priceController.GetByCar(id, DateTime.Today);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetPriceDtoRequest>(request =>
            request.CarId == id), default));
    }
    
    [Test]
    public async Task GetActualPriceByCarId_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _priceController.GetActualPriceByCar(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetActualPriceByCarRequest>(request =>
            request.CarId == id), default));
    }
    
    [Test]
    public async Task Delete_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _priceController.Delete(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<DeletePriceRequest>(request =>
            request.Id == id), default));
    }
    
    [Test]
    public async Task Create_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var priceHistoryDto = new RequestPriceHistoryDto();

        // Act
        await _priceController.Create(priceHistoryDto);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<CreatePriceRequest>(request =>
            request.PriceDto == priceHistoryDto), default));
    }
    
    [Test]
    public async Task Update_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var modelDto = new RequestPriceHistoryDto();
        var id = Guid.NewGuid();

        // Act
        await _priceController.Update(id, modelDto);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<UpdatePriceRequest>(request =>
            request.Id == id && request.PriceDto == modelDto), default));
    }
}