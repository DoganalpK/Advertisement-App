using AspNetCore.AdvertisementApp.Business.Interfaces;
using AspNetCore.AdvertisementApp.DataAccess.UnitOfWork;
using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.AdvertisementApp.Business.Services
{
    public class AppUserService : Service<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>, IAppUserService
    {
        public AppUserService(IMapper mapper, IValidator<AppUserCreateDto> createDtoValitador, IValidator<AppUserUpdateDto> updateDtoValidator, IUow uow)
            : base(mapper, createDtoValitador, updateDtoValidator, uow)
        {
        }
    }
}
