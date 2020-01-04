using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BracketMap.DAL.Entities
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public int TournamentId { get; set; }
        public string TeamName { get; set; }
        public virtual List<FightTeamMap> FightTeams { get; set; } = new List<FightTeamMap>();
    }
}
