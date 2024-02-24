using MediatR;
using Microsoft.AspNetCore.Mvc;
using WheelsCatalog.Application.Common.Exceptions;
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
    public async Task<ActionResult<PaginatedList<RespondCarDto>>> Get([FromQuery] PaginationParameters? paginationParams)
    {
        var command = new GetCarDtoListRequest { PaginationParameters = paginationParams };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("details")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<RespondCarDto>>> GetWithDependencies()
    {
        var result = await _mediator.Send(new GetCarDtoListDetailsRequest());
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondCarDto>> Get(Guid? id)
    {
        if (id == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting car.");
        
        var command = new GetCarDtoRequest() { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("/api/models/{modelId:guid}/cars")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<RespondCarDto>>> GetCarsByModel(Guid? modelId, [FromQuery] PaginationParameters? paginationParams)
    {
        if (modelId == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting car.");
        
        var command = new GetCarDtoListByModelRequest { Id = modelId, PaginationParameters = paginationParams};
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("/api/colors/{colorId:guid}/cars")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<RespondCarDto>>> GetCarsByColor(Guid? colorId, [FromQuery] PaginationParameters? paginationParams)
    {
        if (colorId == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting car.");
        
        var command = new GetCarDtoListByColorRequest { Id = colorId, PaginationParameters = paginationParams};
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("/api/brands/{brandId:guid}/cars")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<RespondCarDto>>> GetCarsByBrand(Guid? brandId, [FromQuery] PaginationParameters? paginationParams)
    {
        if (brandId == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting car.");
        
        var command = new GetCarDtoListByBrandRequest { Id = brandId, PaginationParameters = paginationParams};
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
        if (id == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting car.");
        
        var command = new GetCarDtoDetailsRequest() { Id = id };
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
        if (carId == null || photo == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting photos of car.");
        
        var command = new CreateCarDtoPhotosRequest() { Id = carId, Photo = photo };
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
        if (photoId == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting photos of car.");
        
        var command = new DeleteCarDtoPhotosRequest() { Id = photoId };
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
        if (request == null)
            throw new BadRequestException("Request body is null. Cannot proceed with car creation.");
        
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
        if (id == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with car deletion.");
        
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
        if (request == null)
            throw new BadRequestException("Request body is null. Cannot proceed with car updating.");
        
        var command = new UpdateCarRequest { Id = id, CarDto = request };
        var response = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, response.Value);
    }
}