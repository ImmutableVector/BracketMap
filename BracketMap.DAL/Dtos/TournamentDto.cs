using BracketMap.DAL.Entities;
using System.Collections.Generic;

namespace BracketMap.DAL.Dtos
{
    public class TournamentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayerCount { get; set; }
        public int TeamCount { get; set; }
        public string Status { get; set; }
        public List<Fight> Fights { get; set; }
        public List<Team> Teams { get; set; }

        public Tournament ToEntity(TournamentDto dto) => new Tournament
        {
            Name = dto.Name,
            PlayerCount = dto.PlayerCount,
            TeamCount = dto.TeamCount,
            Status = dto.Status,
            Fights = dto.Fights,
            Teams = dto.Teams,
        };
    }
}
