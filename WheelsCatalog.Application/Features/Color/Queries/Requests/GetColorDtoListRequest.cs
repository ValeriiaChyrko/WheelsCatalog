using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Color.Queries.Requests;

public class GetColorDtoListRequest : IRequest<List<RespondColorDto>>
{ }