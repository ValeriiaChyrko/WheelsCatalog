using FluentValidation;

namespace WheelsCatalog.Application.Features.Currency.Queries.Requests.Validators;

public class GetCurrencyDtoRequestValidator : AbstractValidator<GetCurrencyDtoRequest>
{
    public GetCurrencyDtoRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}