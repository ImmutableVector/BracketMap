namespace BracketMap.DAL.Entities
{
    public class Fight
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public int WinnerTeamId { get; set; }
    }
}
