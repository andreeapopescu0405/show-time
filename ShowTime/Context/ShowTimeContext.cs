using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ShowTime.Models;


namespace ShowTime.Context
{
    public class ShowTimeContext : DbContext
    {
        public ShowTimeContext(DbContextOptions<ShowTimeContext> options) : base(options) { }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<FestivalBand> FestivalsBands { get; set; }
        // public DbSet<User> Users { get; set; }
    

   protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FestivalBand>()
                .HasKey(sc => new { sc.FestivalId, sc.BandId });

            modelBuilder.Entity<FestivalBand>()
                .HasOne(sc => sc.Festival)
                .WithMany(s => s.FestivalsBands)
                .HasForeignKey(sc => sc.FestivalId);

            modelBuilder.Entity<FestivalBand>()
                .HasOne(sc => sc.Band)
                .WithMany(c => c.FestivalsBands)
                .HasForeignKey(sc => sc.BandId);
        }
    }
}
