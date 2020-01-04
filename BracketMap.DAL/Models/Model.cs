using BracketMap.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BracketMap.DAL.Models
{
    public class BracketMapContext : DbContext
    {
        public BracketMapContext(DbContextOptions<BracketMapContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Player>()
            //    .HasOne(t => t.Team)
            //    .WithMany(p => p.Players)
            //    .HasForeignKey(t => t.TeamId);

            //modelBuilder.Entity<Team>()
            //    .HasOne(t => t.Tournament)
            //    .WithMany(x => x.Teams)
            //    .HasForeignKey(t => t.TournamentId);

            //modelBuilder.Entity<Fight>()
            //    .HasOne(t => t.Tournament)
            //    .WithMany(f => f.Fights)
            //    .HasForeignKey(t => t.TournamentId);

            modelBuilder.Entity<FightTeamMap>()
                .HasKey(ft => new { ft.FightId, ft.TeamId });

            modelBuilder.Entity<FightTeamMap>()
                .HasOne(x => x.Fight)
                .WithMany(x => x.FightTeams)
                .HasForeignKey(x => x.FightId);

            modelBuilder.Entity<FightTeamMap>()
                .HasOne(x => x.Team)
                .WithMany(x => x.FightTeams)
                .HasForeignKey(x => x.TeamId);


            modelBuilder.Entity<Library2Book>().HasKey(k => new { k.LibraryId, k.BookId });

            modelBuilder.Entity<Library2Book>()
                .HasOne(x => x.Book)
                .WithMany(x => x.Library2Books)
                .HasForeignKey(x => x.BookId);

            modelBuilder.Entity<Library2Book>()
               .HasOne(x => x.Library)
               .WithMany(x => x.Library2Books)
               .HasForeignKey(x => x.LibraryId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Fight> Fights { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Library> Libraries { get; set; }
    }

    public class Library
    {
        [Key]
        public int LibraryId { get; set; }
        public List<Library2Book> Library2Books { get; set; } = new List<Library2Book>();
    }

    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public List<Library2Book> Library2Books { get; set; } = new List<Library2Book>();
    }

    public class Library2Book
    {
        [Key]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Key]
        public int LibraryId { get; set; }
        public Library Library { get; set; }
    }

}
