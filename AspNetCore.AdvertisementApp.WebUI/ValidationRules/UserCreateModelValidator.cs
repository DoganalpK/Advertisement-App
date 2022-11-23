using AspNetCore.AdvertisementApp.WebUI.Models;
using FluentValidation;

namespace AspNetCore.AdvertisementApp.WebUI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(3);
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Passwords do not match.");
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Username).MinimumLength(3);
            RuleFor(x => new
            {
                x.Username,
                x.Firstname
            }).Must(x => CanNotFirstname(x.Username, x.Firstname)).WithMessage("Username cannot contain your name.").When(x => x.Username != null && x.Firstname != null);

            RuleFor(x => x.GenderId).NotEmpty();
        }
        private bool CanNotFirstname(string username, string firstname)
        {
            return !username.Contains(firstname);
        }
    }
}
