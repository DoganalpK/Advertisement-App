using AspNetCore.AdvertisementApp.Dtos.Interfaces;
using System;

namespace AspNetCore.AdvertisementApp.Dtos
{
    public class AdvertisementUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
