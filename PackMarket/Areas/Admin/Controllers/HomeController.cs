using Microsoft.AspNetCore.Mvc;
using PackMarket.Core.Services.Interfaces;

namespace PackMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
