using AspNetCore.AdvertisementApp.Dtos;
using FluentValidation;

namespace AspNetCore.AdvertisementApp.Business.ValidationRules.FluentValidation
{
    public class ProviderServiceCreateDtoValidator : AbstractValidator<ProviderServiceCreateDto>
    {
        public ProviderServiceCreateDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.ImagePath).NotEmpty();
        }
    }
}
