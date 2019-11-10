namespace BracketMap.DAL.Entities
{
    public class FightTeamMap
    {
        public int FightId { get; set; }
        public Fight Fight { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
