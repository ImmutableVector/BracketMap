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
        public DbSet<BracketData> NodeMaps { get; set; }
        public DbSet<Player> Players { get; set; }
    }

    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayerCount { get; set; }
    }

    public class BracketData
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public ICollection<Player> PlayerId { get; set; }
        public int Victor { get; set; }
    }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
