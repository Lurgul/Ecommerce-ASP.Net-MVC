using GameStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        private readonly AppDbContext _context;
        public GameController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allGames = await _context.Game.ToListAsync();
            return View(allGames);
        }
    }
}
