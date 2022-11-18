using AspNetCore.AdvertisementApp.Dtos.Interfaces;
using System;

namespace AspNetCore.AdvertisementApp.Dtos
{
    public class AdvertisementCreateDto : IDto
    {
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
