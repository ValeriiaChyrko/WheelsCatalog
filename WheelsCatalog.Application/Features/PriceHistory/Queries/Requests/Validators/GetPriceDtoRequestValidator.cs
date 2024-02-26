using FluentValidation;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Requests.Validators;

public class GetPriceDtoRequestValidator : AbstractValidator<GetPriceDtoRequest>
{
    public GetPriceDtoRequestValidator()
    {
        RuleFor(x => x.CarId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
        
        RuleFor(dto => dto.Date)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .Must(BeValidDate).WithMessage("{PropertyName} must be a valid date.");
    }
    
    private static bool BeValidDate(DateTime? date)
    {
        return !date.Equals(default(DateTime));
    }
    
}