using Microsoft.AspNetCore.Mvc;
using PackMarket.Core.Services.Interfaces;

namespace PackMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private ISliderService _SlidrService;

        public SliderController(ISliderService slidrService)
        {
            _SlidrService = slidrService;
        }
        public IActionResult Index()
        {
            return View(_SlidrService.ShowAllSliders());
        }
    }
}
