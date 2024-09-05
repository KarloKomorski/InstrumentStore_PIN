using Microsoft.EntityFrameworkCore;

namespace GuitarStore.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {

        }

        public DbSet<UserAccounts> UserAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {             
            base.OnModelCreating(modelBuilder);               
        }
    }
}
