using MediatR;
using Microsoft.AspNetCore.Mvc;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;
using WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

namespace WheelsCatalog.API.Controllers;

[Route("api/prices")]
[Produces("application/json")]
[ApiController]
public class PriceController : ControllerBase
{
    private readonly IMediator _mediator;

    public PriceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Guid>> Create([FromBody] RequestPriceDto? request)
    {
        if (request == null)
            throw new BadRequestException("Request body is null. Cannot proceed with price creation.");

        var command = new CreatePriceRequest { PriceDto = request };
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
            throw new BadRequestException("Parameters of request is null. Cannot proceed with price deletion.");

        var command = new DeletePriceRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result.Value);
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RespondPriceDto>> Update(Guid? id, RequestPriceDto? request)
    {
        if (request == null)
            throw new BadRequestException("Request body is null. Cannot proceed with price updating.");

        var command = new UpdatePriceRequest { Id = id, PriceDto = request };
        var response = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, response.Value);
    }

    [HttpGet("/api/cars/{id:guid}/prices")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondPriceDto>> GetActualPriceByCar(Guid? id)
    {
        if (id == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting prices.");

        var command = new GetActualPriceByCarRequest { CarId = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("{carId:guid} {dateTime:datetime}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondBrandDto>> GetByCar(Guid? carId, DateTime? dateTime)
    {
        if (dateTime == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting price.");

        var command = new GetPriceDtoRequest { CarId = carId, Date = dateTime };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("max")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondPriceDto>> GetMaxPrice(DateTime? dateTime)
    {
        var command = new GetMaxPriceRequest { Date = dateTime };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("min")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondPriceDto>> GetMinPrice(DateTime? dateTime)
    {
        var command = new GetMinPriceRequest { Date = dateTime };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
}