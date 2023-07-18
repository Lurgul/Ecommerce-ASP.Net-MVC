using GameStore.Data;
using GameStore.Data.Services;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;
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
            var data = await _service.GetAll();
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
            _service.Add(platform);
            return RedirectToAction(nameof(Index));
        }
    }
}