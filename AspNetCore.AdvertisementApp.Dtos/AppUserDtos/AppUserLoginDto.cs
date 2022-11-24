using AspNetCore.AdvertisementApp.Dtos.Interfaces;

namespace AspNetCore.AdvertisementApp.Dtos
{
    public class AppUserLoginDto : IDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
