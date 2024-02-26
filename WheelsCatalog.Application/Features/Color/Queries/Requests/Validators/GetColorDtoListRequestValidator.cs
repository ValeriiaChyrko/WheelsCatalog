using FluentValidation;
using WheelsCatalog.Application.Contracts.Presentation.Validators;

namespace WheelsCatalog.Application.Features.Color.Queries.Requests.Validators;

public class GetColorDtoListRequestValidator : AbstractValidator<GetColorDtoListRequest>
{
    public GetColorDtoListRequestValidator()
    {
        RuleFor(x => x.PaginationParameters)
            .SetValidator(new PaginationParametersValidator()!)
            .When(x=>x.PaginationParameters != null);
    }
}