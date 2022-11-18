using AspNetCore.AdvertisementApp.Dtos;
using FluentValidation;

namespace AspNetCore.AdvertisementApp.Business.ValidationRules.FluentValidation
{
    public class ProviderServiceUpdateDtoValidator:AbstractValidator<ProviderServiceUpdateDto>
    {
        public ProviderServiceUpdateDtoValidator()
        {
            RuleFor(x=> x.Id).NotEmpty();
            RuleFor(x=> x.Description).NotEmpty();
            RuleFor(x=> x.Title).NotEmpty();
            RuleFor(x => x.ImagePath).NotEmpty();
        }
    }
}
