using GameStore.Data;
using GameStore.Data.Services;
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
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
