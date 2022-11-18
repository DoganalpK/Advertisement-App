using AspNetCore.AdvertisementApp.Business.Interfaces;
using AspNetCore.AdvertisementApp.WebUI.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCore.AdvertisementApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProviderServiceService _providerService;
        private readonly IAdvertisementService _advertisementService;

        public HomeController(IProviderServiceService providerService, IAdvertisementService advertisementService)
        {
            _providerService = providerService;
            _advertisementService = advertisementService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> HumanResource()
        {
            var response = await _advertisementService.GetActivesAsync();
            return this.ResponseView(response);
        }
    }
}
