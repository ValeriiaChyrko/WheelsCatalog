using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Requests.Validators;

public class UpdatePriceRequestValidator : AbstractValidator<UpdatePriceRequest>
{
    public UpdatePriceRequestValidator()
    {
        RuleFor(x => x.PriceDto)
            .NotNull().WithMessage("Об'єкт ціни повинен бути переданий в метод.")
            .SetValidator(new RequestPriceHistoryDtoValidator()!);
        
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор ціни є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор ціни не повинен бути пустим GUID.");
    }
}