namespace BracketMap.DAL.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
    }
}
