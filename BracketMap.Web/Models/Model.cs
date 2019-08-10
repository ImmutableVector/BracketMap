using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class BracketMapContext : DbContext
    {
        public BracketMapContext(DbContextOptions<BracketMapContext> options)
            : base(options)
        { }

        public DbSet<Tournement> Tournements { get; set; }
        public DbSet<NodeMap> NodeMaps { get; set; }
        public DbSet<Player> Players { get; set;  }
    }

    public class Tournement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayerCount { get; set; }

    }

    public class NodeMap
    {
        public int Id { get; set; }
        public ICollection<Player> Players { get; set; }
        public int Victor { get; set; }
    }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
