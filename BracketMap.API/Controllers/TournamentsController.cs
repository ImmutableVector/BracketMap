using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BracketMap.DAL.Models;
using BracketMap.DAL.Dtos;

namespace BracketMap.Web.Controllers
{
    [Route("tournament")]
    [ApiController]

    // TODO: Right now I am just using the db context directly in the controller, this needs to be refactored into the n-tier 
    // layers and is only acting as a poc. Once we commit to the primary design, we can get this cleaned up.
    public class TournamentsController : ControllerBase
    {
        private readonly BracketMapContext _context;

        public TournamentsController(BracketMapContext context)
        {
            _context = context;
        }

        // GET: tournaments
        [HttpGet("All")]
        public async Task<ActionResult<IEnumerable<TournamentDto>>> GetTournaments()
        {
            return await _context.Tournaments
                .Select(x => new TournamentDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    TeamCount = x.TeamCount,
                    Status = x.Status
                }).ToListAsync();
        }

        // GET: tournaments/1
        [HttpGet]
        public async Task<ActionResult<TournamentDto>> GetTournament(int id)
        {
            var tournament = await _context.Tournaments.FindAsync(id);

            if (tournament == null)
            {
                return NotFound();
            }

            return TournamentDto.ToModel(tournament);
        }

        // PUT: tournaments/1
        [HttpPut]
        public async Task<IActionResult> PutTournament(TournamentDto tournament)
        {
            if (tournament.Id == null)
            {
                return BadRequest();
            }

            _context.Entry(tournament).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TournamentExists(tournament.Id ?? 0))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: tournaments
        [HttpPost]
        public async Task<ActionResult<int>> PostTournament(TournamentDto tournament)
        {
            tournament.Status = "Pending";
            var entity = tournament.ToEntity();
            _context.Tournaments.Add(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        // DELETE: tournaments/1
        [HttpDelete]
        public async Task<ActionResult> DeleteTournament(int id)
        {
            var tournament = await _context.Tournaments.FindAsync(id);
            if (tournament == null)
            {
                return NotFound();
            }

            _context.Tournaments.Remove(tournament);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TournamentExists(int id)
        {
            return _context.Tournaments.Any(e => e.Id == id);
        }
    }
}
