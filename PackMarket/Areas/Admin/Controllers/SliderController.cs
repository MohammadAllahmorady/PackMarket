using Microsoft.AspNetCore.Mvc;
using PackMarket.Core.ExtentionMthods;
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
        public IActionResult Index(int page=1)
        {
            ViewBag.page = page;
            ViewBag.CountSlider = _SlidrService.SliderCount();
            return View(_SlidrService.ShowAllSliders(page));
        }
        [HttpGet]
        public IActionResult AddSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSlider(MainSlider mainSlider,IFormFile? file)
        {

            if (!ModelState.IsValid)
                return View(mainSlider);


            if (file==null)
            {
               ModelState.AddModelError("SliderImage", "لطفا یک تصویر برای اسلایدر انتخاب کنید!");
               return View(mainSlider);
            }
            string imgname = Uplodimg.Createimage(file);
            if (imgname=="false")
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(Index));
            }
            mainSlider.SliderImage=imgname;

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
        public IActionResult UpdateSlider(MainSlider mainSlider,IFormFile? file)
        {
            if (!ModelState.IsValid)
                return View(mainSlider);
            if (file!=null)
            {
                string imgname = Uplodimg.Createimage(file);
                if (imgname == "false")
                {
                    TempData["Result"] = "false";
                    return RedirectToAction(nameof(Index));
                }

                bool DeleteImg = Uplodimg.DeleteImg("images", mainSlider.SliderImage);
                if (!DeleteImg)
                {
                    TempData["Result"] = "false";
                    return RedirectToAction(nameof(Index));
                }
                mainSlider.SliderImage= imgname;
            }
            var res = _SlidrService.UpdateSlider(mainSlider);
            TempData["Result"] = res == true ? "true" : "false";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult DeleteSlider(int id)
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
        public IActionResult DeleteSlider(MainSlider mainSlider)
        {
            bool DeleteImg = Uplodimg.DeleteImg("images", mainSlider.SliderImage);
            if (!DeleteImg)
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(Index));
            }

            bool res = _SlidrService.DeleteSlider(mainSlider);
            TempData["Result"]=res==true ? "true" : "false";    
            return RedirectToAction(nameof(Index));
        }
    }
}
