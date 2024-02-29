using FluentValidation;
using WheelsCatalog.Application.Common;

namespace WheelsCatalog.Application.DTOs.requestsDtos.validators
{
    public class RequestCarDtoValidator : AbstractValidator<RequestCarDto>
    {
        private const int MaxLengthDescriptionLength = Constants.MaxLengthDescriptionPropertyLength;
        
        public RequestCarDtoValidator()
        {
            RuleFor(dto => dto.Description)
                .NotEmpty().WithMessage("Опис автомобіля не може бути порожнім.")
                .MaximumLength(MaxLengthDescriptionLength).WithMessage($"Опис автомобіля не повинен перевищувати {MaxLengthDescriptionLength} символів.")
                .When(p => p.Description != null);

            RuleFor(dto => dto.EngineVolume)
                .GreaterThan(0).WithMessage("Об'єм двигуна повинен бути більше нуля.");
            
            RuleFor(p => p.ModelId)
                .NotEmpty().WithMessage("Ідентифікатор моделі автомобіля є обов'язковим полем.")
                .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор моделі не повинен бути пустим GUID.");
            
            RuleFor(p => p.ColorId)
                .NotEmpty().WithMessage("Ідентифікатор кольору автомобіля є обов'язковим полем.")
                .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор кольору не повинен бути пустим GUID.");
        }
    }
}