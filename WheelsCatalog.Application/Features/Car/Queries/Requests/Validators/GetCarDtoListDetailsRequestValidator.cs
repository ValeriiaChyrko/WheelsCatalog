using FluentValidation;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests.Validators;

public class GetCarDtoListDetailsRequestValidator : AbstractValidator<GetCarDtoListDetailsRequest>
{
    public GetCarDtoListDetailsRequestValidator()
    {
        //RuleFor(x => x.PaginationParameters).SetValidator(new PaginationParametersValidator()!).When(x=>x.PaginationParameters != null);
    }
}