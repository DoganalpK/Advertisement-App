using AspNetCore.AdvertisementApp.Dtos.Interfaces;

namespace AspNetCore.AdvertisementApp.Dtos
{
    public class AppRoleCreateDto : IDto
    {
        public int Id { get; set; }
        public string Difinition { get; set; }
    }
}
