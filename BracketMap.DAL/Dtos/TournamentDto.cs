using BracketMap.DAL.Models;

namespace BracketMap.DAL.Dtos
{
    public class TournamentDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int PlayerCount { get; set; }
        public int TeamCount { get; set; }
        public string Status { get; set; }

        public static TournamentDto ToModel(Tournament entity)
        {
            return new TournamentDto
            {
                Id = entity.Id,
                Name = entity.Name,
                PlayerCount = entity.PlayerCount,
                TeamCount = entity.TeamCount,
                Status = entity.Status
            };
        }

        public Tournament ToEntity()
        {
            return new Tournament
            {
                Id = Id ?? 0,
                Name = Name,
                PlayerCount = PlayerCount,
                TeamCount = TeamCount,
                Status = Status
            };
        }
    }
}
