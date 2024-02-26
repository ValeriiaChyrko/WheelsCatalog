using FluentValidation;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Requests.Validators;

public class DeletePriceRequestValidator : AbstractValidator<DeletePriceRequest>
{
    public DeletePriceRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}