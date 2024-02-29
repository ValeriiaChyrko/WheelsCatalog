using FluentValidation;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Requests.Validators;

public class DeletePriceRequestValidator : AbstractValidator<DeletePriceRequest>
{
    public DeletePriceRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор ціни є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор ціни не повинен бути пустим GUID.");
    }
}