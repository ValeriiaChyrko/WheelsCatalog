using FluentValidation;

namespace WheelsCatalog.Application.Features.Color.Queries.Requests.Validators;

public class GetColorDtoRequestValidator : AbstractValidator<GetColorDtoRequest>
{
    public GetColorDtoRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор кольору є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор кольору не повинен бути пустим GUID.");
    }
}