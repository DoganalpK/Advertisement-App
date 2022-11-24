using AspNetCore.AdvertisementApp.Business.Mappings.AutoMapper;
using AutoMapper;
using System.Collections.Generic;

namespace AspNetCore.AdvertisementApp.Business.Profiles
{
    public static class Profiles
    {
        public static List<Profile> GetProfiles()
        {
            return new List<Profile>
            {
                new ProviderServiceProfile(),
                new AdvertisementProfile(),
                new AppUserProfile(),
                new GenderProfile(),
                new AppRoleProfile(),
            };
        }
    }
}
