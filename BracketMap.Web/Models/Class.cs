using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BracketMap.Web.Models
{
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

    public class ApplicationUser : IdentityUser
    {
    }
}
