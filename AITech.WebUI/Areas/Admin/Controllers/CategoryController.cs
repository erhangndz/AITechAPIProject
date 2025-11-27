using AITech.WebUI.DTOs.CategoryDtos;
using AITech.WebUI.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(ICategoryService _categoryService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto categoryDto)
        {
            await _categoryService.CreateAsync(categoryDto);
            return RedirectToAction("Index");
        }
    }
}
