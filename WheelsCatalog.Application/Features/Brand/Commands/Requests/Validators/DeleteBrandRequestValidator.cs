using FluentValidation;

namespace WheelsCatalog.Application.Features.Brand.Commands.Requests.Validators;

public class DeleteBrandRequestValidator : AbstractValidator<DeleteBrandRequest>
{
    public DeleteBrandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор бренду є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор бренду не повинен бути пустим GUID.");
    }
}