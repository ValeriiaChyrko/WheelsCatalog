using FluentValidation;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Requests.Validators;

public class GetMaxPriceRequestValidator : AbstractValidator<GetMaxPriceRequest>
{
    public GetMaxPriceRequestValidator()
    {
        RuleFor(dto => dto.Date)
            .NotEmpty().WithMessage("Дата початку дії ціни є обов'язковим полем.")
            .Must(BeValidDate).WithMessage("Введена дата має бути коректною.");
    }
    
    private static bool BeValidDate(DateTime? date)
    {
        return !date.Equals(default(DateTime));
    }
}