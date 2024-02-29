using FluentValidation;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Requests.Validators;

public class GetPriceDtoRequestValidator : AbstractValidator<GetPriceDtoRequest>
{
    public GetPriceDtoRequestValidator()
    {
        RuleFor(x => x.CarId)
            .NotEmpty().WithMessage("Ідентифікатор автомобіля є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор автомобіля не повинен бути пустим GUID.");
        
        RuleFor(dto => dto.Date)
            .NotEmpty().WithMessage("Дата початку дії ціни є обов'язковим полем.")
            .Must(BeValidDate).WithMessage("Введена дата має бути коректною.");
    }
    
    private static bool BeValidDate(DateTime? date)
    {
        return !date.Equals(default(DateTime));
    }
    
}