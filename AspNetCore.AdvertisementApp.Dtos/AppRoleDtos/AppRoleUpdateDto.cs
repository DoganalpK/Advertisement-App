using AspNetCore.AdvertisementApp.Dtos.Interfaces;

namespace AspNetCore.AdvertisementApp.Dtos
{
    public class AppRoleUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
