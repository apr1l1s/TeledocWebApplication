using Microsoft.EntityFrameworkCore;
using TeledocWebApplication.Core.Configuration;
using TeledocWebApplication.Core.Model;

namespace TeledocWebApplication.Core
{
    public class TeledocDbContext : DbContext
    {
        public DbSet<Client> clients { get; set; } = null!;
        public DbSet<Founder> founders { get; set; } = null!;
        public TeledocDbContext(DbContextOptions options)
            : base(options) {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new FounderConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
