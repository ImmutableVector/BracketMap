using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BracketMap.DAL.Dtos;
using BracketMap.Business.Services.Interfaces;

namespace BracketMap.Web.Controllers
{
    [Route("tournament")]
    [ApiController]

    public class TournamentsController : ControllerBase
    {
        private readonly ITournamentService _tournamentService;

        public TournamentsController(ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        // GET: tournaments
        [HttpGet]
        public async Task<ActionResult<List<TournamentDto>>> GetTournaments()
            => Ok(await _tournamentService.GetTournaments());

        // GET: tournaments/1
        [HttpGet("{id}")]
        public async Task<ActionResult<TournamentDto>> GetTournament(int id)
        {
            var tournament = await _tournamentService.GetTournamentById(id);

            if (tournament == null)
            {
                return NotFound();
            }

            return Ok(tournament);
        }

        //// PUT: tournaments/1
        //[HttpPut]
        //public async Task<IActionResult> PutTournament(TournamentDto tournament)
        //{
        //    if (tournament.Id == default)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(tournament).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TournamentExists(tournament.Id ?? 0))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: tournaments
        [HttpPost]
        public async Task<ActionResult<int>> PostTournament(TournamentDto dto)
            => Ok(await _tournamentService.SaveTournament(dto));

        //// DELETE: tournaments/1
        //[HttpDelete]
        //public async Task<ActionResult> DeleteTournament(int id)
        //{
        //    var tournament = await _context.Tournaments.FindAsync(id);
        //    if (tournament == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Tournaments.Remove(tournament);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool TournamentExists(int id)
        //{
        //    return _context.Tournaments.Any(e => e.Id == id);
        //}
    }
}
