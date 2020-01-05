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

            //modelBuilder.Entity<FightTeamMap>().HasKey(ft => new { ft.FightId, ft.TeamId });

            //modelBuilder.Entity<FightTeamMap>()
            //    .HasOne(x => x.Fight)
            //    .WithMany(x => x.FightTeams)
            //    .HasForeignKey(x => x.FightId);
           
            //modelBuilder.Entity<FightTeamMap>()
            //    .HasOne(x => x.Team)
            //    .WithMany(x => x.FightTeams)
            //    .HasForeignKey(x => x.TeamId);


            modelBuilder.Entity<Library2Book>().HasKey(k => new { k.LibraryId, k.BookId });
            modelBuilder.Entity<Library2Book>()
                .HasOne(x => x.Book)
                .WithMany(x => x.Library2Books)
                .HasForeignKey(x => x.BookId);

            modelBuilder.Entity<Library2Book>()
               .HasOne(x => x.Library)
               .WithMany(x => x.Library2Books)
               .HasForeignKey(x => x.LibraryId);

            modelBuilder.Entity<Library2Book2>().HasKey(k => new { k.LibraryId, k.BookId });
            modelBuilder.Entity<Library2Book2>()
                .HasOne(x => x.Book)
                .WithMany(x => x.Library2Book2s)
                .HasForeignKey(x => x.BookId);

            modelBuilder.Entity<Library2Book2>()
               .HasOne(x => x.Library)
               .WithMany(x => x.Library2Book2s)
               .HasForeignKey(x => x.LibraryId);




            modelBuilder.Entity<FightTeamMap>().HasKey(k => new { k.TeamId, k.FightId });
            modelBuilder.Entity<FightTeamMap>()
                .HasOne(x => x.Fight)
                .WithMany(x => x.FightTeams)
                .HasForeignKey(x => x.FightId);

            modelBuilder.Entity<FightTeamMap>()
               .HasOne(x => x.Team)
               .WithMany(x => x.FightTeams)
               .HasForeignKey(x => x.TeamId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Fight> Fights { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Library> Libraries { get; set; }

        public DbSet<Book2> Books2 { get; set; }

        public DbSet<Library2> Libraries2 { get; set; }
    }


    public class Fight
    {
        [Key]
        public int FightId { get; set; }
        public List<FightTeamMap> FightTeams { get; set; } = new List<FightTeamMap>();
    }

    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public List<FightTeamMap> FightTeams { get; set; } = new List<FightTeamMap>();
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

    public class Library2
    {
        [Key]
        public int LibraryId { get; set; }
        public List<Library2Book2> Library2Book2s { get; set; } = new List<Library2Book2>();
    }

    public class Book2
    {
        [Key]
        public int BookId { get; set; }
        public List<Library2Book2> Library2Book2s { get; set; } = new List<Library2Book2>();
    }

    public class FightTeamMap
    {
        [Key]
        public int FightId { get; set; }
        public Fight Fight { get; set; }

        [Key]
        public int TeamId { get; set; }
        public Team Team { get; set; }

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



    public class Library2Book2
    {
        [Key]
        public int BookId { get; set; }
        public Book2 Book { get; set; }

        [Key]
        public int LibraryId { get; set; }
        public Library2 Library { get; set; }
    }

}
