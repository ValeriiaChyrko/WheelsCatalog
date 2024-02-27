using FluentValidation;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests.Validators;

public class GetCarDtoListWithFiltersRequestValidator : AbstractValidator<GetCarDtoListWithFiltersRequest>
{
    public GetCarDtoListWithFiltersRequestValidator()
    {
        //RuleFor(x => x.PaginationParameters).SetValidator(new PaginationParametersValidator()!).When(x=>x.PaginationParameters != null);
    }
}