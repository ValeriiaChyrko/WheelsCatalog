using FluentValidation;

namespace WheelsCatalog.Application.DTOs.requestsDtos.validators;

public class RequestPriceDtoValidator : AbstractValidator<RequestPriceDto>
{
    public RequestPriceDtoValidator()
    {
        RuleFor(dto => dto.Amount)
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than zero.");

        RuleFor(dto => dto.Date)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .Must(BeValidDate).WithMessage("{PropertyName} must be a valid date.");
        
        RuleFor(dto => dto.CurrencyId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
        
        RuleFor(dto => dto.CarId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }

    private static bool BeValidDate(DateTime? date)
    {
        return !date.Equals(default(DateTime));
    }
}