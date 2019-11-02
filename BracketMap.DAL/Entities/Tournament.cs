using System.Collections.Generic;

namespace BracketMap.DAL.Entities
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayerCount { get; set; }
        public int TeamCount { get; set; }
        public string Status { get; set; }
        public ICollection<Fight> Fights { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
