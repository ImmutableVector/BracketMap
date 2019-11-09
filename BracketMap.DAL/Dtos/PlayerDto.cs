using System.Collections.Generic;
using BracketMap.DAL.Entities;

namespace BracketMap.DAL.Dtos
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }

        public Player ToEntity(PlayerDto dto) => new Player
        {
            TeamId = dto.TeamId,
            Name = dto.Name,
        };
    }
}
