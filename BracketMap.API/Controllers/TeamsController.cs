using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BracketMap.DAL.Models;
using BracketMap.DAL.Dtos;

namespace BracketMap.Web.Controllers
{
    [Route("team")]
    [ApiController]

    // TODO: Right now I am just using the db context directly in the controller, this needs to be refactored into the n-tier 
    // layers and is only acting as a poc. Once we commit to the primary design, we can get this cleaned up.
    public class TeamsController : ControllerBase
    {
        private readonly BracketMapContext _context;

        public TeamsController(BracketMapContext context)
        {
            _context = context;
        }

        // GET: Team
        //[HttpGet("GetTeamsByTournamentId")]
        //public async Task<ActionResult<IEnumerable<TeamsDto>>> GetTeams(int tournamentId)
        //{
        //    return await _context.Teams
        //        .Where(x => x.TournamentId == tournamentId)
        //        .Select( x => new TeamsDto()
        //        {
        //            Id = x.Id,
        //            TournamentId = x.TournamentId,
        //            TeamName = x.TeamName,
        //            Players = x.Players,
        //        }).ToListAsync();
        //}

        //[HttpPost]
        //public async Task<ActionResult> PostTournament(TeamsDto team)
        //{
        //    var entity = team.ToEntity();
        //    _context.Teams.Add(entity);
        //    await _context.SaveChangesAsync();

        //    return Ok();
        //}
    }
}
