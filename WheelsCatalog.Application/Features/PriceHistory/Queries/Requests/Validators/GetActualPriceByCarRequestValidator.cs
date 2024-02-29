using FluentValidation;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Requests.Validators;

public class GetActualPriceByCarRequestValidator : AbstractValidator<GetActualPriceByCarRequest>
{
    public GetActualPriceByCarRequestValidator()
    {
        RuleFor(x => x.CarId)
            .NotEmpty().WithMessage("Ідентифікатор автомобіля є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор автомобіля не повинен бути пустим GUID.");
    }
}