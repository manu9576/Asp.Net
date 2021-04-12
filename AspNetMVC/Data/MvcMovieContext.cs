using AspNetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetMVC.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            :base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
