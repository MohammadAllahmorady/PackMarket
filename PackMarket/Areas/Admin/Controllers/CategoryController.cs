using Microsoft.AspNetCore.Mvc;
using PackMarket.Core.Services.Interfaces;

namespace PackMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService=categoryService;
        }
        public IActionResult ShowAllCategory()
        {
            return View(_categoryService.ShowAllCategories());
        }
    }
}
