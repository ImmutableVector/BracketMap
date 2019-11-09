using System.Collections.Generic;
using BracketMap.DAL.Entities;

namespace BracketMap.DAL.Dtos
{
    public class TeamDto
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public string TeamName { get; set; }
        public List<PlayerDto> Players { get; set; }

        public Team ToEntity(TeamDto dto) => new Team
        {
            TournamentId = dto.TournamentId,
            TeamName = dto.TeamName,
        };
    }
}