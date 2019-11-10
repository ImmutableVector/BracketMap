using System.Collections.Generic;

namespace BracketMap.DAL.Entities
{
    public class Fight
    {
        public int FightId { get; set; }
        public int TournamentId { get; set; }
        public int? WinnerTeamId { get; set; }
        public Tournament Tournament { get; set; }
        public virtual IList<FightTeamMap> FightTeams {get; set;}
    }
}
