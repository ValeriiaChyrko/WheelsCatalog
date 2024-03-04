using MediatR;
using Moq;
using WheelsCatalog.API.Controllers;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.API.Tests;

[TestFixture]
public class BrandControllerTests
{
    private BrandController _brandController = null!;
    private Mock<IMediator> _mediatorMock = null!;

    [SetUp]
    public void Setup()
    {
        _mediatorMock = new Mock<IMediator>();
        _brandController = new BrandController(_mediatorMock.Object);
    }
    
    [Test]
    public async Task Get_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var filteringParameters = new BrandFilteringParameters();

        // Act
        await _brandController.Get(filteringParameters);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetBrandDtoListWithFiltersRequest>(request =>
            request.FilteringParameters == filteringParameters), default));
    }
    
    [Test]
    public async Task GetBrandsAmount_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var filteringParameters = new BrandFilteringParameters();

        // Act
        await _brandController.GetBrandsAmount(filteringParameters);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetBrandDtoListWithFiltersCountRequest>(request =>
            request.FilteringParameters == filteringParameters), default));
    }
    
    [Test]
    public async Task GetBrandById_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _brandController.Get(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetBrandDtoRequest>(request =>
            request.Id == id), default));
    }
    
    [Test]
    public async Task GetDetails_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _brandController.GetDetails(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<GetBrandDtoDetailsRequest>(request =>
            request.Id == id), default));
    }
    
    [Test]
    public async Task Delete_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _brandController.Delete(id);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<DeleteBrandRequest>(request =>
            request.Id == id), default));
    }
    
    [Test]
    public async Task Create_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var brandDto = new RequestBrandDto();

        // Act
        await _brandController.Create(brandDto);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<CreateBrandRequest>(request =>
            request.BrandDto == brandDto), default));
    }
    
    [Test]
    public async Task Update_Calls_Mediator_With_Correct_Request()
    {
        // Arrange
        var brandDto = new RequestBrandDto();
        var id = Guid.NewGuid();

        // Act
        await _brandController.Update(id, brandDto);

        // Assert
        _mediatorMock.Verify(m => m.Send(It.Is<UpdateBrandRequest>(request =>
            request.Id == id && request.BrandDto == brandDto), default));
    }
}