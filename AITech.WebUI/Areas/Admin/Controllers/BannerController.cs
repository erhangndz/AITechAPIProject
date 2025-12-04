using AITech.WebUI.DTOs.BannerDtos;
using AITech.WebUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController(IBannerService _bannerService) : Controller
    {

        public async Task<IActionResult> Index()
        {
            var banners = await _bannerService.GetAllAsync();
            return View(banners);
        }

        public IActionResult CreateBanner()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto bannerDto)
        {
            await _bannerService.CreateAsync(bannerDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateBanner(int id)
        {
            var banner = await _bannerService.GetByIdAsync(id);
            return View(banner);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto bannerDto)
        {
            await _bannerService.UpdateAsync(bannerDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> MakeActive(int id)
        {
            await _bannerService.MakeActiveAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> MakePassive(int id)
        {
            await _bannerService.MakePassiveAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteBanner(int id)
        {
            await _bannerService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
