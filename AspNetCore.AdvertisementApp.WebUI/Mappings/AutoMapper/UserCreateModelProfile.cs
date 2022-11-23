using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.WebUI.Models;
using AutoMapper;

namespace AspNetCore.AdvertisementApp.WebUI.Mappings.AutoMapper
{
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>().ReverseMap();
        }
    }
}
