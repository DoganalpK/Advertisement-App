using AspNetCore.AdvertisementApp.Common.Enums;
using AspNetCore.AdvertisementApp.Dtos;
using FluentValidation;

namespace AspNetCore.AdvertisementApp.Business.ValidationRules.FluentValidation
{
    public class AdvertisementAppUserCreateDtoValidator : AbstractValidator<AdvertisementAppUserCreateDto>
    {
        public AdvertisementAppUserCreateDtoValidator()
        {
            RuleFor(x => x.AdvertisementAppUserStatusId).NotEmpty();
            RuleFor(x => x.AdvertisementId).NotEmpty();
            RuleFor(x => x.AppUserId).NotEmpty();
            RuleFor(x => x.CvPath).NotEmpty();
            RuleFor(x => x.EndDate).NotEmpty().When(x => x.MilitaryStatusId == (int)MilitaryStatusType.Defereed);
            RuleFor(x => x.WorkExperience).NotEmpty();
        }
    }
}
