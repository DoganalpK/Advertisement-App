using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;

namespace AspNetCore.AdvertisementApp.Business.Interfaces
{
    public interface IGenderService : IService<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>
    {
    }
}
