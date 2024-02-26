using FluentValidation;
using WheelsCatalog.Application.Contracts.Presentation.Validators;

namespace WheelsCatalog.Application.Features.Currency.Queries.Requests.Validators;

public class GetCurrencyDtoListRequestValidator : AbstractValidator<GetCurrencyDtoListRequest>
{
    public GetCurrencyDtoListRequestValidator()
    {
        RuleFor(x => x.PaginationParameters)
            .SetValidator(new PaginationParametersValidator()!)
            .When(x=>x.PaginationParameters != null);
    }
}