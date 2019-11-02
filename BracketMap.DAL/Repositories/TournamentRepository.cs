using BracketMap.DAL.Dtos;
using BracketMap.DAL.Entities;
using BracketMap.DAL.Models;
using BracketMap.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketMap.DAL.Repositories
{
    public class TournamentRepository : ITournamentRepository
    {
        private readonly BracketMapContext _context;

        public TournamentRepository(BracketMapContext context)
        {
            _context = context;
        }

        public async Task<List<TournamentDto>> GetTournaments()
        {
            return await _context.Tournaments
                .Include(x => x.Teams)
                .Include(x => x.Fights)
                .Select(x => new TournamentDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    TeamCount = x.TeamCount,
                    PlayerCount = x.PlayerCount,
                    Status = x.Status,
                    Fights = x.Fights.ToList(),
                    Teams = x.Teams.ToList()
                })
                .ToListAsync();
        }

        public async Task<TournamentDto> GetTournamentById(int id)
        {
            return await _context.Tournaments
                .Include(x => x.Teams)
                .Include(x => x.Fights)
                .Select(x => new TournamentDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    TeamCount = x.TeamCount,
                    PlayerCount = x.PlayerCount,
                    Status = x.Status,
                    Fights = x.Fights.ToList(),
                    Teams = x.Teams.ToList()
                })
                .SingleOrDefaultAsync(x=> x.Id == id);
        }


        public async Task<int> SaveTournament(TournamentDto dto)
        {
            dto.Status = "Pending";
            var entity = dto.ToEntity(dto);
            _context.Tournaments.Add(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
    }
}
