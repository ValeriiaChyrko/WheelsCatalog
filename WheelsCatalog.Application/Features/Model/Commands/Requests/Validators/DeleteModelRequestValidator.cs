using FluentValidation;

namespace WheelsCatalog.Application.Features.Model.Commands.Requests.Validators;

public class DeleteModelRequestValidator : AbstractValidator<DeleteModelRequest>
{
    public DeleteModelRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор моделі є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор моделі не повинен бути пустим GUID.");
    }
}