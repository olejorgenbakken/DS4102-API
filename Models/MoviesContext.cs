using Microsoft.EntityFrameworkCore;

namespace moviesAPI.Models
{

    public class MoviesContext : DbContext
    {

        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) { }

        public DbSet<Movies> Movies { get; set; }
    }

}