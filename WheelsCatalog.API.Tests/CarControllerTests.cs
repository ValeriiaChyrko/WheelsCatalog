using MediatR;
using Moq;
using WheelsCatalog.API.Controllers;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.API.Tests;

[TestFixture]
public class CarControllerTests
{
    private CarController _carController = null!;
    private Mock<IMediator> _mediatorMock = null!;

    [SetUp]
    public void Setup()
    {
        _mediatorMock = new Mock<IMediator>();
        _carController = new CarController(_mediatorMock.Object);
    }
    
    [Test]
    public async Task Get_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var filteringParameters = new CarFilteringParameters();
        var priceFilteringParameters = new PriceFilteringParameters();

        // Act
        await _carController.Get(filteringParameters, priceFilteringParameters);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetCarDtoListWithFiltersRequest>(request =>
            request.CarFilteringParameters == filteringParameters && request.PriceFilteringParameters == priceFilteringParameters), default));
    }
    
    [Test]
    public async Task GetCarsAmount_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var filteringParameters = new CarFilteringParameters();
        var priceFilteringParameters = new PriceFilteringParameters();

        // Act
        await _carController.Get(filteringParameters, priceFilteringParameters);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetCarDtoListWithFiltersCountRequest>(request =>
            request.CarFilteringParameters == filteringParameters && request.PriceFilteringParameters == priceFilteringParameters), default));
    }
    
    [Test]
    public async Task GetEngineVolumeMax_Calls_Mediator_With_Correct_Request()
    {
        // Act
        await _carController.GetEngineVolumeMax();

        // Assert
        _mediatorMock.Verify(m => m.Send(It.IsAny<GetCarDtoEngineVolumeMaxRequest>(), default));
    }
    
    [Test]
    public async Task GetEngineVolumeMin_Calls_Mediator_With_Correct_Request()
    {
        // Act
        await _carController.GetEngineVolumeMin();

        // Assert
        _mediatorMock.Verify(m => m.Send(It.IsAny<GetCarDtoEngineVolumeMinRequest>(), default));
    }
    
    [Test]
    public async Task GetCarById_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _carController.Get(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetCarDtoRequest>(request =>
            request.Id == id), default));
    }
    
    [Test]
    public async Task GetDetails_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _carController.GetDetails(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetCarDtoDetailsRequest>(request =>
            request.Id == id), default));
    }
    
    [Test]
    public async Task Delete_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _carController.Delete(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<DeleteCarRequest>(request =>
            request.Id == id), default));
    }
    
    [Test]
    public async Task Create_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var carDto = new RequestCarDto();

        // Act
        await _carController.Create(carDto);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<CreateCarRequest>(request =>
            request.CarDto == carDto), default));
    }
    
    [Test]
    public async Task Update_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var carDto = new RequestCarDto();
        var id = Guid.NewGuid();

        // Act
        await _carController.Update(id, carDto);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<UpdateCarRequest>(request =>
            request.Id == id && request.CarDto == carDto), default));
    }
}