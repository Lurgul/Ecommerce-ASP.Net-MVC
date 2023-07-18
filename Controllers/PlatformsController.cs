using GameStore.Data;
using GameStore.Data.Services;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GameStore.Controllers
{
    public class PlatformsController : Controller
    {
        private readonly IPlatformsService _service;
        public PlatformsController(IPlatformsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        // Get: Platforms/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("PlatformPicture,PlatformName,Description")]Platforms platform)
        {
            if(!ModelState.IsValid)
            {
                return View(platform);
            }
            await _service.AddAsync(platform);
            return RedirectToAction(nameof(Index));
        }

        // Get: Platforms / Details
        public async Task<IActionResult> Details(int id)
        {
            var platformDetails = await _service.GetByIdAsync(id);
            if (platformDetails == null) return View("Not Found!");
            return View(platformDetails);
        }

        // Get: Platforms/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var platformDetails = await _service.GetByIdAsync(id);
            if (platformDetails == null) return View("Not Found!");
            return View(platformDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("PlatformsId,PlatformPicture,PlatformName,Description")] Platforms platform)
        {
            if (!ModelState.IsValid)
            {
                return View(platform);
            }
            await _service.UpdateAsync(id,platform);
            return RedirectToAction(nameof(Index));

        }
        // Get: Platforms/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var platformDetails = await _service.GetByIdAsync(id);
            if (platformDetails == null) return View("Not Found!");
            return View(platformDetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var platformDetails = await _service.GetByIdAsync(id);
            if (platformDetails == null) return View("Not Found!");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }
    }
}