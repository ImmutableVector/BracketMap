using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BracketMap.DAL.Entities
{
    public class Fight
    {
        [Key]
        public int FightId { get; set; }
        public int TournamentId { get; set; }
        public int? WinnerTeamId { get; set; }
        public virtual List<FightTeamMap> FightTeams { get; set; } = new List<FightTeamMap>();
    }
}
