using AspNetCore.AdvertisementApp.Business.Interfaces;
using AspNetCore.AdvertisementApp.DataAccess.UnitOfWork;
using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;
using AutoMapper;
using FluentValidation;

namespace AspNetCore.AdvertisementApp.Business.Services
{
    public class GenderService : Service<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>, IGenderService
    {
        public GenderService(IMapper mapper, IValidator<GenderCreateDto> createDtoValitador, IValidator<GenderUpdateDto> updateDtoValidator, IUow uow) 
            : base(mapper, createDtoValitador, updateDtoValidator, uow)
        {
        }
    }
}
