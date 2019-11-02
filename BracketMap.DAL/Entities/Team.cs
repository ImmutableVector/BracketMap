﻿using System.Collections.Generic;

namespace BracketMap.DAL.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public string TeamName { get; set; }
        public List<int> Players { get; set; }
    }
}
