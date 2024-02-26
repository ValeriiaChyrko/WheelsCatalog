using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Model.Commands.Requests.Validators;

public class UpdateModelRequestValidator : AbstractValidator<UpdateModelRequest>
{
    public UpdateModelRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
        
        RuleFor(x => x.ModelDto)
            .NotNull().WithMessage("ModelDto must not be null.")
            .SetValidator(new RequestModelDtoValidator()!);
    }
}