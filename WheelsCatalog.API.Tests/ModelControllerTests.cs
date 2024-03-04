using MediatR;
using Moq;
using WheelsCatalog.API.Controllers;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Application.Features.Model.Queries.Requests;

namespace WheelsCatalog.API.Tests;

[TestFixture]
public class ModelControllerTests
{
    private ModelController _modelController = null!;
    private Mock<IMediator> _mediatorMock = null!;

    [SetUp]
    public void Setup()
    {
        _mediatorMock = new Mock<IMediator>();
        _modelController = new ModelController(_mediatorMock.Object);
    }
    
    [Test]
    public async Task Get_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var filteringParameters = new ModelFilteringParameters();

        // Act
        await _modelController.Get(filteringParameters);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetModelDtoListWithFiltersRequest>(request =>
            request.FilteringParameters == filteringParameters), default));
    }
    
    [Test]
    public async Task GetModelsAmount_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var filteringParameters = new ModelFilteringParameters();

        // Act
        await _modelController.GetAmount(filteringParameters);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetModelDtoListCountRequest>(request =>
            request.FilteringParameters == filteringParameters), default));
    }
    
    [Test]
    public async Task GetModelById_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _modelController.Get(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetModelDtoRequest>(request =>
            request.Id == id), default));
    }
    
    [Test]
    public async Task Delete_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _modelController.Delete(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<DeleteModelRequest>(request =>
            request.Id == id), default));
    }
    
    [Test]
    public async Task Create_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var modelDto = new RequestModelDto();

        // Act
        await _modelController.Create(modelDto);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<CreateModelRequest>(request =>
            request.ModelDto == modelDto), default));
    }
    
    [Test]
    public async Task Update_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var modelDto = new RequestModelDto();
        var id = Guid.NewGuid();

        // Act
        await _modelController.Update(id, modelDto);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<UpdateModelRequest>(request =>
            request.Id == id && request.ModelDto == modelDto), default));
    }
}