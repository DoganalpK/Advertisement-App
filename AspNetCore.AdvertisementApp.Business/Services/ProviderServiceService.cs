using AspNetCore.AdvertisementApp.Business.Interfaces;
using AspNetCore.AdvertisementApp.DataAccess.UnitOfWork;
using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.Entities;
using AutoMapper;
using FluentValidation;

namespace AspNetCore.AdvertisementApp.Business.Services
{
    public class ProviderServiceService : Service<ProviderServiceCreateDto, ProviderServiceUpdateDto, ProviderServiceListDto, ProviderService>, IProviderServiceService
    {
        public ProviderServiceService(IMapper mapper, IValidator<ProviderServiceCreateDto> createDtoValitador, IValidator<ProviderServiceUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValitador, updateDtoValidator, uow)
        {
        }
    }
}
