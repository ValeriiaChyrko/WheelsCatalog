using MediatR;
using Microsoft.AspNetCore.Mvc;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Color.Queries.Requests;

namespace WheelsCatalog.API.Controllers;

[Route("api/colors")]
[Produces("application/json")]
[ApiController]
public class ColorController : ControllerBase
{
    private readonly IMediator _mediator;

    public ColorController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<PaginatedList<RespondColorDto>>> Get(
        [FromQuery] PaginationParameters? paginationParams)
    {
        var command = new GetColorDtoListRequest { PaginationParameters = paginationParams };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("count")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<int>>> GetAmount()
    {
        var command = new GetColorDtoListCountRequest();
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondColorDto>> Get(Guid? id)
    {
        if (id == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting color.");

        var command = new GetColorDtoRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
}