using FluentValidation;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Requests.Validators;

public class GetActualPriceByCarRequestValidator : AbstractValidator<GetActualPriceByCarRequest>
{
    public GetActualPriceByCarRequestValidator()
    {
        RuleFor(x => x.CarId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}