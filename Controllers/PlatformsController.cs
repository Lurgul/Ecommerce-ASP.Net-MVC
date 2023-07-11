using GameStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GameStore.Controllers
{
    public class PlatformsController : Controller
    {
        private readonly AppDbContext _context;
        public PlatformsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Platforms.ToList();
            return View(data);
        }
    }
}
