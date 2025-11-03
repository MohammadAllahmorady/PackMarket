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
        //[HttpGet]
        //public IActionResult AddColor()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AddColor(ProductColor productColor)
        //{
        //    if (!ModelState.IsValid)
        //    return View(productColor);

        //    int colorId = _productService.AddColor(productColor);
        //    TempData["Result"]=colorId>0?"true":"false";
        //    return RedirectToAction(nameof(index));
        //}
    }
}
