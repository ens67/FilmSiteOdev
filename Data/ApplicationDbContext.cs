using Microsoft.EntityFrameworkCore;
using MovieArchiveApp.Models; 

namespace MovieArchiveApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}