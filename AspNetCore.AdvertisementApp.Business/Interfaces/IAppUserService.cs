using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;

namespace AspNetCore.AdvertisementApp.Business.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>
    {
    }
}
