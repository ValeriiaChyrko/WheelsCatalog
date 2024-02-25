using MediatR;
using Microsoft.AspNetCore.Mvc;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.API.Controllers;

[Route("api/brands")]
[Produces("application/json")]
[ApiController]
public class BrandController : ControllerBase
{
    private readonly IMediator _mediator;

    public BrandController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<PaginatedList<RespondBrandDto>>> Get(
        [FromQuery] PaginationParameters? paginationParams)
    {
        var command = new GetBrandDtoListRequest { PaginationParameters = paginationParams };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }
    
    [HttpGet("count")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<PaginatedList<RespondBrandDto>>> GetBrandsAmount()
    {
        var command = new GetBrandDtoListLengthRequest();
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondBrandDto>> Get([FromRoute] Guid? id)
    {
        if (id == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting brand.");

        var command = new GetBrandDtoRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpGet("{id:guid}/details")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<RespondBrandDtoDetails>> GetDetails([FromQuery] Guid? id)
    {
        if (id == null)
            throw new BadRequestException("Parameters of request is null. Cannot proceed with getting brand.");

        var command = new GetBrandDtoDetailsRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Guid>> Create([FromBody] RequestBrandDto? request)
    {
        if (request == null)
            throw new BadRequestException("Request body is null. Cannot proceed with brand creation.");

        var command = new CreateBrandRequest { BrandDto = request };
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
            throw new BadRequestException("Parameters of request is null. Cannot proceed with brand deletion.");

        var command = new DeleteBrandRequest { Id = id };
        var result = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, result.Value);
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RespondBrandDto>> Update(Guid? id, RequestBrandDto? request)
    {
        if (request == null)
            throw new BadRequestException("Request body is null. Cannot proceed with brand updating.");

        var command = new UpdateBrandRequest { Id = id, BrandDto = request };
        var response = await _mediator.Send(command);
        return StatusCode(StatusCodes.Status200OK, response.Value);
    }
}