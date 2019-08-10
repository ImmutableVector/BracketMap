using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFGetStarted.AspNetCore.NewDb.Models;

namespace BracketMap.Web.Controllers
{
    [Route("api/Tournement")]
    [ApiController]
    public class TournementsController : ControllerBase
    {
        private readonly BracketMapContext _context;

        public TournementsController(BracketMapContext context)
        {
            _context = context;
        }

        // GET: api/Tournements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tournement>>> GetTournements()
        {
            return await _context.Tournements.ToListAsync();
        }

        // GET: api/Tournements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tournement>> GetTournement(int id)
        {
            var tournement = await _context.Tournements.FindAsync(id);

            if (tournement == null)
            {
                return NotFound();
            }

            return tournement;
        }

        // PUT: api/Tournements/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTournement(int id, Tournement tournement)
        {
            if (id != tournement.Id)
            {
                return BadRequest();
            }

            _context.Entry(tournement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TournementExists(id))
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

        // POST: api/Tournements
        [HttpPost]
        public async Task<ActionResult<Tournement>> PostTournement([FromBody] Tournement tournement)
        {
            _context.Tournements.Add(tournement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTournement", new { id = tournement.Id }, tournement);
        }

        // DELETE: api/Tournements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tournement>> DeleteTournement(int id)
        {
            var tournement = await _context.Tournements.FindAsync(id);
            if (tournement == null)
            {
                return NotFound();
            }

            _context.Tournements.Remove(tournement);
            await _context.SaveChangesAsync();

            return tournement;
        }

        private bool TournementExists(int id)
        {
            return _context.Tournements.Any(e => e.Id == id);
        }
    }
}
