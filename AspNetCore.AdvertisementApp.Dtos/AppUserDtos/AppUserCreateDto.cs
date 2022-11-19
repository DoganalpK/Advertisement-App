using AspNetCore.AdvertisementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.AdvertisementApp.Dtos
{
    public class AppUserCreateDto : IDto
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int GenderId { get; set; }
    }
}
