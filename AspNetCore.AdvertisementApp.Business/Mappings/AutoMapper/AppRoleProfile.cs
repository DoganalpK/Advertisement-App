using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;
using AutoMapper;

namespace AspNetCore.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class AppRoleProfile : Profile
    {
        public AppRoleProfile()
        {
            CreateMap<AppRole, AppRoleListDto>().ReverseMap();
        }
    }
}
