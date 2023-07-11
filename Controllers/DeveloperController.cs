using GameStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Controllers
{
    public class DeveloperController : Controller
    {
        private readonly AppDbContext _context;
        public DeveloperController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allDevelopers = await _context.Developer.ToListAsync();
            return View(allDevelopers);
        }
    }
}
