using MediatR;
using Microsoft.AspNetCore.Mvc;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.API.Controllers;

[Route("api/cars")]
[Produces("application/json")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<PaginatedList<RespondCarDto>>> Get(
        [FromQuery] CarFilteringParameters? filteringParameters,
        [FromQuery] PriceFilteringParameters? priceFilteringParameters)
    {
        var command = new GetCarDtoListWithFiltersRequest
        {
            CarFilteringParameters = filteringParameters,
            PriceFilteringParameters = priceFilteringParameters
        };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("count")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<PaginatedList<RespondBrandDto>>> GetCarsAmount(
        [FromQuery] CarFilteringParameters? filteringParameters,
        [FromQuery] PriceFilteringParameters? priceFilteringParameters)
    {
        var command = new GetCarDtoListWithFiltersCountRequest
        {
            CarFilteringParameters = filteringParameters,
            PriceFilteringParameters = priceFilteringParameters
        };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("/api/engine-volumes/max")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<double>> GetEngineVolumeMax()
    {
        var command = new GetCarDtoEngineVolumeMaxRequest();
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("/api/engine-volumes/min")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<double>> GetEngineVolumeMin()
    {
        var command = new GetCarDtoEngineVolumeMinRequest();
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("details")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<RespondCarDto>>> GetWithDependencies(
        [FromQuery] CarFilteringParameters? filteringParameters,
        [FromQuery] PriceFilteringParameters? priceFilteringParameters)
    {
        var command = new GetCarDtoListDetailsRequest
        {
            CarFilteringParameters = filteringParameters,
            PriceFilteringParameters = priceFilteringParameters
        };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondCarDto>> Get(Guid? id)
    {
        var command = new GetCarDtoRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("{id:guid}/details")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondCarDtoDetails>> GetDetails(Guid? id)
    {
        var command = new GetCarDtoDetailsRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpPost("photos/{carId:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Guid>> GetPhotos(Guid? carId, FileDto photo)
    {
        var command = new CreateCarDtoPhotosRequest{ CarId = carId, Photo = photo };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result.Value);
    }

    [HttpDelete("photos/{photoId:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Guid>> DeletePhotos(Guid? photoId)
    {
        var command = new DeleteCarDtoPhotosRequest { Id = photoId };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result.Value);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Guid>> Create([FromBody] RequestCarDto? request)
    {
        var command = new CreateCarRequest { CarDto = request };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status201Created, result.Value);
    }

    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Guid>> Delete(Guid? id)
    {
        var command = new DeleteCarRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result.Value);
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RespondCarDto>> Update(Guid? id, RequestCarDto? request)
    {
        var command = new UpdateCarRequest { Id = id, CarDto = request };
        var response = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, response.Value);
    }
}