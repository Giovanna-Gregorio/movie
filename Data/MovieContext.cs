using Microsoft.EntityFrameworkCore;
using movie2.Models;

namespace movie2.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {
            
        }

        public DbSet<Movie> Movie { get; set; }
        //public DbSet<Actor> Actor { get; set; }
    }
}