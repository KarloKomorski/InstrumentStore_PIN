using GuitarStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GuitarStore.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
