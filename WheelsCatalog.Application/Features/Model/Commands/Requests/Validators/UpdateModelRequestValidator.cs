using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Model.Commands.Requests.Validators;

public class UpdateModelRequestValidator : AbstractValidator<UpdateModelRequest>
{
    public UpdateModelRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор моделі є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор моделі не повинен бути пустим GUID.");
        
        RuleFor(x => x.ModelDto)
            .NotNull().WithMessage("Об'єкт моделі повинен бути переданий в метод.")
            .SetValidator(new RequestModelDtoValidator()!);
    }
}