using AspNetCore.AdvertisementApp.Business.Interfaces;
using AspNetCore.AdvertisementApp.Business.Mappings.AutoMapper;
using AspNetCore.AdvertisementApp.Common.Enums;
using AspNetCore.AdvertisementApp.Dtos;
using AspNetCore.AdvertisementApp.WebUI.Extensions;
using AspNetCore.AdvertisementApp.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AspNetCore.AdvertisementApp.WebUI.Controllers
{
    public class Advertisement : Controller
    {
        private readonly IAppUserService _userService;
        private readonly IAdvertisementAppUserService _advertisementAppUserService;

        public Advertisement(IAppUserService userService, IAdvertisementAppUserService advertisementAppUserService)
        {
            _userService = userService;
            _advertisementAppUserService = advertisementAppUserService;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AppliedList(AdvertisementAppUserStatusType type)
        {
            var list = await _advertisementAppUserService.GetListAsync(type);
            return View(list);
        }

        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Send(int advertisementId)
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value);
            var userResponse = await _userService.GetByIdAsync<AppUserListDto>(userId);
            var user = userResponse.Data;
            var militaryStatus = Enum.GetValues(typeof(MilitaryStatusType));
            var list = new List<MilitaryStatusListDto>();

            foreach (int item in militaryStatus)
            {
                list.Add(new MilitaryStatusListDto
                {
                    Id = item,
                    Definition = Enum.GetName(typeof(MilitaryStatusType), item)
                });
            }

            return View(new AdvertisementAppUserCreateModel
            {
                AdvertisementId = advertisementId,
                AppUserId = user.Id,
                MilitaryList = list
            });
        }

        [Authorize(Roles = "Member")]
        [HttpPost]
        public async Task<IActionResult> Send(AdvertisementAppUserCreateModel model)
        {
            AdvertisementAppUserCreateDto dto = new();
            if (model.CvFile != null)
            {
                var fileName = Guid.NewGuid().ToString();
                var extName = Path.GetExtension(model.CvFile.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "CvFiles", fileName + extName);
                var stream = new FileStream(path, FileMode.Create);
                await model.CvFile.CopyToAsync(stream);
                dto.CvPath = path;
            }

            dto.AdvertisementAppUserStatusId = model.AdvertisementAppUserStatusId;
            dto.AdvertisementId = model.AdvertisementId;
            dto.AppUserId = model.AppUserId;
            dto.EndDate = model.EndDate;
            dto.MilitaryStatusId = model.MilitaryStatusId;
            dto.WorkExperience = model.WorkExperience;

            var response = await _advertisementAppUserService.CreateAsync(dto);
            if (response.ResponseType == ResponseType.ValidationError)
            {
                foreach (var error in response.ValidationErrors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(model);
            }

            return this.ResponseRedirectAction(response, "HumanResource", "Home");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SetStatus(int advertisementAppUserId, AdvertisementAppUserStatusType type)
        {
            await _advertisementAppUserService.SetStatusAsync(advertisementAppUserId, type);
            return RedirectToAction("AppliedList");
        }
    }
}
