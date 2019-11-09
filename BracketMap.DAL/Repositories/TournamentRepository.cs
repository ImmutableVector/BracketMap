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
                .Select(tournament => new TournamentDto
                {
                    Id = tournament.Id,
                    Name = tournament.Name,
                    TeamsPerFight = tournament.TeamsPerFight,
                    PlayersPerTeam = tournament.PlayersPerTeam,
                    Status = tournament.Status,
                    // Fights = x.Fights.SelectToList(),
                    Teams = tournament.Teams
                    .Select(team => new TeamDto
                    {
                        TournamentId = team.TournamentId,
                        TeamName = team.TeamName,
                        Players = team.Players
                        .Select(player => new PlayerDto
                        {
                            Id = player.Id,
                            TeamId = player.TeamId,
                            Name = player.Name,
                        })
                        .ToList()
                    })
                    .ToList()
                })
                .ToListAsync();
        }

        public async Task<TournamentDto> GetTournamentById(int id)
        {
            return await _context.Tournaments
                .Select(tournament => new TournamentDto
                {
                    Id = tournament.Id,
                    Name = tournament.Name,
                    TeamsPerFight = tournament.TeamsPerFight,
                    PlayersPerTeam = tournament.PlayersPerTeam,
                    Status = tournament.Status,
                    // Fights = x.Fights.ToList(),
                    Teams = tournament.Teams
                    .Select(team => new TeamDto
                    { 
                        TournamentId = team.TournamentId,
                        TeamName = team.TeamName,
                        Players = team.Players
                        .Select(player => new PlayerDto
                        {
                            Id = player.Id,
                            TeamId = player.TeamId,
                            Name = player.Name,
                        })
                        .ToList()
                    })
                    .ToList()
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
