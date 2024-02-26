using FluentValidation;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Requests.Validators;

public class GetMinPriceRequestValidator : AbstractValidator<GetMinPriceRequest>
{
    public GetMinPriceRequestValidator()
    {
        RuleFor(dto => dto.Date)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .Must(BeValidDate).WithMessage("{PropertyName} must be a valid date.");
    }
    
    private static bool BeValidDate(DateTime? date)
    {
        return !date.Equals(default(DateTime));
    }
}