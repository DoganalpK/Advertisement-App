using AspNetCore.AdvertisementApp.Dtos.Interfaces;
using AspNetCore.AdvertisementApp.Entities;

namespace AspNetCore.AdvertisementApp.Dtos
{
    public class AppUserListDto : IDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
    }
}
