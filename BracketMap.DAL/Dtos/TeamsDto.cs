﻿using System.Collections.Generic;
using BracketMap.DAL.Entities;

namespace BracketMap.DAL.Dtos
{
    public class TeamsDto
    {
        public int? Id { get; set; }
        public int TournamentId { get; set; }
        public string TeamName { get; set; }
        public List<int> Players { get; set; }

        //public static TeamsDto ToModel(Team entity)
        //{
        //    return new TeamsDto
        //    {
        //        Id = entity.Id,
        //        TournamentId = entity.TournamentId,
        //        TeamName = entity.TeamName,
        //        Players = entity.Players.Select( p => new PlayerDto { Id = p.}),
        //    };
        //}

        //public Team ToEntity()
        //{
        //    return new Team
        //    {
        //        Id = Id ?? 0,
        //        TournamentId = TournamentId,
        //        TeamName = TeamName,
        //        Players = Players.,
        //    };
        //}

        //public TeamsDto GetTeamsByTournamentId(int TournamentId)
        //{
        //    using new 
        //}
    }
}
