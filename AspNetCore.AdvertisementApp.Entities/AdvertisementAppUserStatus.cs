using System.Collections.Generic;

namespace AspNetCore.AdvertisementApp.Entities
{
    public class AdvertisementAppUserStatus : BaseEntity
    {
        public string Defination { get; set; }
        public List<AdvertisementAppUser> AdvertisementAppUsers { get; set; }
    }
}
