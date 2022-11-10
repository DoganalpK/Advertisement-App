using AspNetCore.AdvertisementApp.Dtos.ProviderServiceDtos;
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
            CreateMap<ProviderServiceListDto, ProviderServiceListDto>().ReverseMap();
        }
    }
}
