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

            modelBuilder.Entity<FightTeamMap>()
                .HasKey(ft => new { ft.FightId, ft.TeamId });

            modelBuilder.Entity<FightTeamMap>()
                .HasOne<Fight>(ft => ft.Fight)
                .WithMany(f => f.FightTeams)
                .HasForeignKey(ft => ft.FightId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FightTeamMap>()
                .HasOne<Team>(ft => ft.Team)
                .WithMany(f => f.FightTeams)
                .HasForeignKey(ft => ft.TeamId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Fight> Fights { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
