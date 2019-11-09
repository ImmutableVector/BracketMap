using BracketMap.DAL.Entities;
using System.Collections.Generic;

namespace BracketMap.DAL.Dtos
{
    public class TournamentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayersPerTeam { get; set; }
        public int TeamsPerFight { get; set; }
        public string Status { get; set; }
        public List<FightDto> Fights { get; set; }
        public List<TeamDto> Teams { get; set; }

        public Tournament ToEntity(TournamentDto dto) => new Tournament
        {
            Name = dto.Name,
            PlayersPerTeam = dto.PlayersPerTeam,
            TeamsPerFight = dto.TeamsPerFight,
            Status = dto.Status
        };
    }
}
