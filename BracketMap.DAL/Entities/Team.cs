using System.Collections.Generic;

namespace BracketMap.DAL.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public int TournamentId { get; set; }
        public string TeamName { get; set; }
        public Tournament Tournament { get; set; }
        public ICollection<Player> Players { get; set; }
        public virtual ICollection<FightTeamMap> FightTeams { get; set; }
    }
}
