using Microsoft.AspNetCore.Mvc;
using PackMarket.Core.Services.Interfaces;
using PackMarket.DataLayer.Entities.Entitieproduct;

namespace PackMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService=productService;
        }
        public IActionResult ShowAllColor()
        {
           return View(_productService.ShowAllColor());
        }
        [HttpGet]
        public IActionResult AddColor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddColor(ProductColor productColor)
        {
            if (!ModelState.IsValid)
                return View(productColor);
            if (_productService.ExistColor(productColor.ColorName, productColor.ColorCode,0))
            {
                ModelState.AddModelError("ColorCode", "رنگ انتخابی تکراری است.");
                return View(productColor);
            }
            int colorId = _productService.AddColor(productColor);
            TempData["Result"] = colorId > 0 ? "true" : "false";
            return RedirectToAction(nameof(ShowAllColor));
        }

        [HttpGet]
        public IActionResult UpdateColor(int id)
        {
            ProductColor productColor = _productService.FindColorById(id);
            if (productColor == null)
            {
                return NotFound();
            }

            return View(productColor);
        }

        [HttpPost]
        public IActionResult UpdateColor(ProductColor productColor)
        {
            if (!ModelState.IsValid)
                return View(productColor);
            if (_productService.ExistColor(productColor.ColorName,productColor.ColorCode,productColor.ColorId))
            {
                ModelState.AddModelError("ColorCode", "رنگ انتخابی تکراری است.");
                return View(productColor);
            }

            bool res = _productService.UpdateColor(productColor);
            TempData["Result"] = res == true ? "true" : "false";
            return RedirectToAction(nameof(ShowAllColor));
        }
    }
}
