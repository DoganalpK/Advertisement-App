using AspNetCore.AdvertisementApp.Business.Interfaces;
using AspNetCore.AdvertisementApp.Business.Mappings.AutoMapper;
using AspNetCore.AdvertisementApp.Business.Services;
using AspNetCore.AdvertisementApp.Business.ValidationRules.FluentValidation;
using AspNetCore.AdvertisementApp.DataAccess.Contexts;
using AspNetCore.AdvertisementApp.DataAccess.UnitOfWork;
using AspNetCore.AdvertisementApp.Dtos;
using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace AspNetCore.AdvertisementApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("LocalMsSQL"));
            });

            services.AddScoped<IUow, Uow>();
            services.AddScoped<IProviderServiceService, ProviderServiceService>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IGenderService, GenderService>();

            services.AddTransient<IValidator<ProviderServiceCreateDto>, ProviderServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProviderServiceUpdateDto>, ProviderServiceUpdateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementUpdateDto>, AdvertisementUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();
            services.AddTransient<IValidator<GenderCreateDto>, GenderCreateDtoValidator>();
            services.AddTransient<IValidator<GenderUpdateDto>, GenderUpdateDtoValidator>();
        }        
    }
}
