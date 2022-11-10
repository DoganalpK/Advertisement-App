using AspNetCore.AdvertisementApp.Dtos.Interfaces;
using System;

namespace AspNetCore.AdvertisementApp.Dtos.ProviderServiceDtos
{
    public class ProviderServiceListDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
