using Microsoft.AspNetCore.Mvc;

namespace WebAPI2023.Areas.AreaName.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}