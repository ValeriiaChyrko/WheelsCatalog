using FluentValidation;
using WheelsCatalog.Application.Contracts.Presentation.Validators;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests.Validators;

public class GetBrandDtoListRequestValidator : AbstractValidator<GetBrandDtoListWithFiltersRequest>
{
    public GetBrandDtoListRequestValidator()
    {
        RuleFor(x => x.PaginationParameters)
            .SetValidator(new PaginationParametersValidator()!)
            .When(x=>x.PaginationParameters != null);
    }
}
