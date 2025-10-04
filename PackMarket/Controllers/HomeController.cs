using Microsoft.AspNetCore.Mvc;

namespace PackMarket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
