using AspNetCore.AdvertisementApp.Dtos.Interfaces;

namespace AspNetCore.AdvertisementApp.Dtos
{
    public class GenderUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
