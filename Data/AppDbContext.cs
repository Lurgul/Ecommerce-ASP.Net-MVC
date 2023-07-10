using GameStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace GameStore.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platforms_Games>().HasKey(pm => new
            {
                pm.PlatformId,
                pm.GameId
            });

            modelBuilder.Entity<Platforms_Games>().HasOne(g => g.Game).WithMany(pm => pm.Platforms_Games).HasForeignKey(g => g.GameId);

            modelBuilder.Entity<Platforms_Games>().HasOne(g => g.Platforms).WithMany(pm => pm.Platforms_Games).HasForeignKey(g => g.PlatformId);
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Platforms> Platforms { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Platforms_Games> Platforms_Games { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Developer> Developer { get; set; }
    }
}
