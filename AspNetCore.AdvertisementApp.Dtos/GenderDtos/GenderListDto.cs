using AspNetCore.AdvertisementApp.Dtos.Interfaces;

namespace AspNetCore.AdvertisementApp.Dtos
{
    public class GenderListDto : IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
