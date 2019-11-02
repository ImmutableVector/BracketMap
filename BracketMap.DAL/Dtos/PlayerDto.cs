using System.Collections.Generic;
using BracketMap.DAL.Entities;

namespace BracketMap.DAL.Dtos
{
    public class PlayerDto
    {
        public int? Id { get; set; }
        public int TournamentId { get; set; }
        public string TeamName { get; set; }
    }
}
