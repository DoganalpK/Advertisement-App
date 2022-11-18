using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;
using AutoMapper;

namespace AspNetCore.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class ProviderServiceProfile : Profile
    {
        public ProviderServiceProfile()
        {
            CreateMap<ProviderServiceCreateDto, ProviderService>().ReverseMap();
            CreateMap<ProviderServiceUpdateDto, ProviderService>().ReverseMap();
            CreateMap<ProviderServiceListDto, ProviderService>().ReverseMap();
        }
    }
}
