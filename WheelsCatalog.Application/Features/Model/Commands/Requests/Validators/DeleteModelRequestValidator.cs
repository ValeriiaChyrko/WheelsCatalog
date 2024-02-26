using FluentValidation;

namespace WheelsCatalog.Application.Features.Model.Commands.Requests.Validators;

public class DeleteModelRequestValidator : AbstractValidator<DeleteModelRequest>
{
    public DeleteModelRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}