using GameStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Controllers
{
    public class PublisherController : Controller
    {
        private readonly AppDbContext _context;
        public PublisherController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allPublisher = await _context.Publisher.ToListAsync();
            return View(allPublisher);
        }
    }
}
