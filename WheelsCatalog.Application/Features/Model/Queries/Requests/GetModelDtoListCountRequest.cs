using MediatR;
using WheelsCatalog.Application.Contracts.Presentation;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests;

public class GetModelDtoListCountRequest : IRequest<int>
{
    public ModelFilteringParameters? FilteringParameters { get; init; }
}