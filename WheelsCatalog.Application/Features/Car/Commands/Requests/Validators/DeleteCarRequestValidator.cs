using FluentValidation;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests.Validators;

public class DeleteCarRequestValidator : AbstractValidator<DeleteCarRequest>
{
    public DeleteCarRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор автомобіля є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор автомобіля не повинен бути пустим GUID.");
    }
}