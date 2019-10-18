using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BracketMap.DAL.Models
{
    public class BracketMapContext : DbContext
    {
        public BracketMapContext(DbContextOptions<BracketMapContext> options)
            : base(options)
        { }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Bracket> Brackets { get; set; }
        public DbSet<Team> Teams { get; set; }
    }

    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayerCount { get; set; }
        public int TeamCount { get; set; }
        public string Status { get; set; }
    }

    public class Bracket
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public string TeamIds { get; set; }
        public int Victor { get; set; }

    }
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Players { get; set; }
    }
}
