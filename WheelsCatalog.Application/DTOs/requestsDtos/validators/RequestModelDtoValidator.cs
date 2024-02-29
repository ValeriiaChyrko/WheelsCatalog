using FluentValidation;
using WheelsCatalog.Application.Common;

namespace WheelsCatalog.Application.DTOs.requestsDtos.validators
{
    public class RequestModelDtoValidator : AbstractValidator<RequestModelDto>
    {
        private const int MaxLengthNameLength = Constants.MaxLengthNamePropertyLength;
        private const int MaxLengthDescriptionLength = Constants.MaxLengthDescriptionPropertyLength;
        
        public RequestModelDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Назва моделі є обов'язковим полем.")
                .MaximumLength(MaxLengthNameLength).WithMessage($"Назва моделі не повинна перевищувати {MaxLengthNameLength} символів.");
            
            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("Опис моделі не може бути порожнім.")
                .MaximumLength(MaxLengthDescriptionLength).WithMessage($"Опис моделі не повинен перевищувати {MaxLengthDescriptionLength} символів.")
                .When(p => p.Description != null);

            RuleFor(p => p.BrandId)
                .NotEmpty().WithMessage("Ідентифікатор бренду є обов'язковим полем.")
                .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор бренду не повинен бути пустим GUID.");
            
        }
    }
}