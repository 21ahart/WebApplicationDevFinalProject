using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationDevFinalProject.Data;
using WebApplicationDevFinalProject.Models;

namespace WebApplicationDevFinalProject.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movie/Genre
        public async Task<IActionResult> Genre(string genreStr)
        {
            var movies = from m in _context.Movies
                         select m;

            if (!string.IsNullOrEmpty(genreStr))
            {
                movies = movies.Where(s => s.Genre == genreStr);
            }

            return View(await movies.ToListAsync());
        }

        // GET: Movie/AddMovie
        public IActionResult AddMovie()
        {
            return View();
        }

        // POST: Movie/AddMovie
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMovie([Bind("Id,Title,Genre,ReleaseYear,Rating,Description")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Genre));
            }
            return View(movie);
        }

        // GET: Movie/MovieDetails/5
        public async Task<IActionResult> MovieDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Genre));
        }
    }
}