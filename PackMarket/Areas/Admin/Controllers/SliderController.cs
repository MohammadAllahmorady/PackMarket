using Microsoft.AspNetCore.Mvc;
using PackMarket.Core.Services.Interfaces;
using PackMarket.DataLayer.Entities;

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
        [HttpGet]
        public IActionResult AddSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSlider(MainSlider mainSlider)
        {
            if (!ModelState.IsValid)
                return View(mainSlider);

            int res = _SlidrService.AddSlider(mainSlider);
            TempData["Result"]=res>0?"true":"false";
            return RedirectToAction(nameof(Index));
        }
    }
}
