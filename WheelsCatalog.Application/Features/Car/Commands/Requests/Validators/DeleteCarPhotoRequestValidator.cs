using FluentValidation;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests.Validators;

public class DeleteCarPhotoRequestValidator : AbstractValidator<DeleteCarDtoPhotosRequest>
{
    public DeleteCarPhotoRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}