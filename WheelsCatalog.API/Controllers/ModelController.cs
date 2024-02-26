using MediatR;
using Microsoft.AspNetCore.Mvc;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Application.Features.Model.Queries.Requests;

namespace WheelsCatalog.API.Controllers;

[Route("api/models")]
[Produces("application/json")]
[ApiController]
public class ModelController : ControllerBase
{
    private readonly IMediator _mediator;

    public ModelController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<PaginatedList<RespondModelDto>>> Get(
        [FromQuery] ModelFilteringParameters? filteringParameters,
        [FromQuery] PaginationParameters? paginationParameters)
    {
        var command = new GetModelDtoListWithFiltersRequest { FilteringParameters = filteringParameters, PaginationParameters = paginationParameters };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("count")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<PaginatedList<RespondModelDto>>> GetAmount(
        [FromQuery] ModelFilteringParameters? filteringParameters)
    {
        var command = new GetModelDtoListCountRequest { FilteringParameters = filteringParameters };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondModelDto>> Get(Guid? id)
    {
        var command = new GetModelDtoRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("/api/brands/{id:guid}/models")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<RespondModelDto>>> GetModelsByBrand(Guid? id, 
        [FromQuery] PaginationParameters? paginationParams)
    {
        var command = new GetModelDtoListByBrandRequest { Id = id, PaginationParameters = paginationParams };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("/api/brands/{id:guid}/models/count")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<int>> GetModelsByBrandAmount(Guid? id)
    {
        var command = new GetModelDtoListByBrandCountRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Guid>> Create([FromBody] RequestModelDto? request)
    {
        var command = new CreateModelRequest { ModelDto = request };
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
        var command = new DeleteModelRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result.Value);
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RespondModelDto>> Update(Guid? id, RequestModelDto? request)
    {
        var command = new UpdateModelRequest { Id = id, ModelDto = request };
        var response = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, response.Value);
    }
}