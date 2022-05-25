using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie)
                .WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor)
                .WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        [AllowNull]
        public DbSet<Actor> Actors { get; set; }

        [AllowNull]
        public DbSet<Movie> Movies { get; set; }

        [AllowNull]
        public DbSet<Actor_Movie> Actors_Movies { get; set; }

        [AllowNull]
        public DbSet<Cinema> Cinemas { get; set; }

        [AllowNull]
        public DbSet<Producer> Producers { get; set; }
    }
}
