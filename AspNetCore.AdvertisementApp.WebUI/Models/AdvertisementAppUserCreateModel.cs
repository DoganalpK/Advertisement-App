using AspNetCore.AdvertisementApp.Common.Enums;
using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace AspNetCore.AdvertisementApp.WebUI.Models
{
    public class AdvertisementAppUserCreateModel
    {
        public int AdvertisementId { get; set; }
        public int AppUserId { get; set; }
        public int AdvertisementAppUserStatusId { get; set; } = (int)AdvertisementAppUserStatusType.Applied;
        public int MilitaryStatusId { get; set; }
        public DateTime? EndDate { get; set; }
        public int WorkExperience { get; set; }
        public IFormFile CvFile { get; set; }
        public List<MilitaryStatusListDto> MilitaryList { get; set; }
    }
}
