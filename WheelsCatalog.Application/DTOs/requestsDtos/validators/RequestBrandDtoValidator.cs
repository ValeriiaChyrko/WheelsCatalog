using FluentValidation;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.DTOs.sharedDtos.validators;

namespace WheelsCatalog.Application.DTOs.requestsDtos.validators;

public class RequestBrandDtoValidator : AbstractValidator<RequestBrandDto>
{
    private const int MaxLengthNameLength = Constants.MaxLengthNamePropertyLength;
    private const int MaxLengthDescriptionLength = Constants.MaxLengthDescriptionPropertyLength;
    
    public RequestBrandDtoValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Назва бренду є обов'язковим полем.")
            .MaximumLength(MaxLengthNameLength).WithMessage($"Назва бренду не повинна перевищувати {MaxLengthNameLength} символів.");
    
        RuleFor(p => p.Logo)
            .SetValidator(new FileDtoValidator()!)
            .When(p => p.Logo != null);
    
        RuleFor(p => p.Description)
            .NotEmpty().WithMessage("Опис бренду не може бути порожнім.")
            .MaximumLength(MaxLengthDescriptionLength).WithMessage($"Опис бренду не повинен перевищувати {MaxLengthDescriptionLength} символів.")
            .When(p => p.Description != null);
    }

}