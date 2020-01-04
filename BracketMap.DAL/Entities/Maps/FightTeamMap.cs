using System.ComponentModel.DataAnnotations;

namespace BracketMap.DAL.Entities
{
    public class FightTeamMap
    {
        [Key]
        public int FightId { get; set; }
        public Fight Fight { get; set; }

        [Key]
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
