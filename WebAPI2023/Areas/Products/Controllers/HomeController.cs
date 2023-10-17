using Infrastructure.CustomerConfiguration.Google;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebAPI2023.Areas.AreaName.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly GoogleOptions _googleSettings;

        public HomeController(
            IConfiguration config,
            IOptions<GoogleOptions> googleSettings)
        {
            _config = config;
            _googleSettings = googleSettings.Value;
        }

        public IActionResult Index()
        {
            ViewBag.TestConfiguration = _config["TestParameter"];
            ViewBag.GoogleName = _googleSettings.Name;
            return View();
        }

        public IActionResult Test()
        {
            return Ok();
        }
    }
}