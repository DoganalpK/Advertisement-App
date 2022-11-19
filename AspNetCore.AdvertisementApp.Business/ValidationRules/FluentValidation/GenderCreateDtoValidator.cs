using AspNetCore.AdvertisementApp.Dtos;
using FluentValidation;

namespace AspNetCore.AdvertisementApp.Business.ValidationRules.FluentValidation
{
    public class GenderCreateDtoValidator : AbstractValidator<GenderCreateDto>
    {
        public GenderCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty();
        }
    }
}
