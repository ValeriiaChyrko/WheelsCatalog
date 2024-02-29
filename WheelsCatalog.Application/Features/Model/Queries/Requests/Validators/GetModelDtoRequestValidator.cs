using FluentValidation;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests.Validators;

public class GetModelDtoRequestValidator : AbstractValidator<GetModelDtoRequest>
{
    public GetModelDtoRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор моделі є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор моделі не повинен бути пустим GUID.");
    }
}