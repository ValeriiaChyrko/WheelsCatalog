using FluentValidation;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests.Validators;

public class GetBrandDtoListWithFiltersRequestValidator : AbstractValidator<GetBrandDtoListWithFiltersRequest>
{
    public GetBrandDtoListWithFiltersRequestValidator()
    {
        //RuleFor(x => x.PaginationParameters).SetValidator(new PaginationParametersValidator()!).When(x=>x.PaginationParameters != null);
    }
}
