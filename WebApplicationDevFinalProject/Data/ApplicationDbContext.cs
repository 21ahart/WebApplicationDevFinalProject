using Microsoft.EntityFrameworkCore;
using WebApplicationDevFinalProject.Models;

namespace WebApplicationDevFinalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = null!;
    }
}