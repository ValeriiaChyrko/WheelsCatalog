using FluentValidation;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests.Validators;

public class GetModelDtoListWithFiltersRequestValidator : AbstractValidator<GetModelDtoListWithFiltersRequest>
{
    public GetModelDtoListWithFiltersRequestValidator()
    {
        //RuleFor(x => x.PaginationParameters).SetValidator(new PaginationParametersValidator()!).When(x=>x.PaginationParameters != null);
    }
}