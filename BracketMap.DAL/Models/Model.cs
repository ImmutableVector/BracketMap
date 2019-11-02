using BracketMap.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BracketMap.DAL.Models
{
    public class BracketMapContext : DbContext
    {
        public BracketMapContext(DbContextOptions<BracketMapContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne(t => t.Team)
                .WithMany(p => p.Players)
                .HasForeignKey(t => t.TeamId);

            modelBuilder.Entity<Team>()
                .HasOne(t => t.Tournament)
                .WithMany(x => x.Teams)
                .HasForeignKey(t => t.TournamentId);

            modelBuilder.Entity<Fight>()
                .HasOne(t => t.Tournament)
                .WithMany(f => f.Fights)
                .HasForeignKey(t => t.TournamentId);
        }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Fight> Fights { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
