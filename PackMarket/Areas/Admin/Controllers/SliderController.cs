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
        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            MainSlider mainSlider = _SlidrService.FindSliderById(id);
            if (mainSlider==null)
            {
                TempData["NotFoundSlider"] = true;
                return RedirectToAction(nameof(Index));
            }
            return View(mainSlider);
        }
        [HttpPost]
        public IActionResult UpdateSlider(MainSlider mainSlider)
        {
            if (!ModelState.IsValid)
                return View(mainSlider);

            var res = _SlidrService.UpdateSlider(mainSlider);
            TempData["Result"] = res == true ? "true" : "false";
            return RedirectToAction(nameof(Index));
        }
    }
}
