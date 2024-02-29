using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Model.Commands.Requests.Validators;

public class CreateModelRequestValidator : AbstractValidator<CreateModelRequest>
{
    public CreateModelRequestValidator()
    {
        RuleFor(x => x.ModelDto)
            .NotNull().WithMessage("Об'єкт моделі має бути переданий в метод.")
            .SetValidator(new RequestModelDtoValidator()!);
    }
}