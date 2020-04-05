using Microsoft.EntityFrameworkCore;
using MVCForm.Models;

namespace MVCForm.Data
{
    public class MVCFormContext : DbContext
    {
        public MVCFormContext(DbContextOptions<MVCFormContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}