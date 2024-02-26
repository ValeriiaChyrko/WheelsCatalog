using FluentValidation;

namespace WheelsCatalog.Application.Features.Brand.Commands.Requests.Validators;

public class DeleteBrandRequestValidator : AbstractValidator<DeleteBrandRequest>
{
    public DeleteBrandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}