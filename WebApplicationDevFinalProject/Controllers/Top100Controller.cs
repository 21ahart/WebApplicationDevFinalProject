using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationDevFinalProject.Data;

namespace WebApplicationDevFinalProject.Controllers
{
    public class Top100Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Top100Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies
                .AsNoTracking()
                .OrderByDescending(m => m.Rating)
                .ThenBy(m => m.Title)
                .Take(100)
                .ToListAsync();

            return View(movies);
        }
    }
}
