using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;

namespace AspNetCore.AdvertisementApp.Business.Interfaces
{
    public interface IProviderServiceService:IService<ProviderServiceCreateDto,ProviderServiceUpdateDto,ProviderServiceListDto,ProviderService>
    {
    }
}
