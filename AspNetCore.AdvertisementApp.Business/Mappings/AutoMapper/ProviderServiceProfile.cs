using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;
using AutoMapper;

namespace AspNetCore.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class ProviderServiceProfile : Profile
    {
        public ProviderServiceProfile()
        {
            CreateMap<ProviderService, ProviderServiceCreateDto>().ReverseMap();
            CreateMap<ProviderService, ProviderServiceUpdateDto>().ReverseMap();
            CreateMap<ProviderService, ProviderServiceListDto>().ReverseMap();
        }
    }
}
