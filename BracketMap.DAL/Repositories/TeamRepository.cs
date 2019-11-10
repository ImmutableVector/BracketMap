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
    public class TeamRepository : ITeamRepository
    {
        private readonly BracketMapContext _context;

        public TeamRepository(BracketMapContext context)
        {
            _context = context;
        }

        public async Task<int> SaveTeam(TeamDto dto)
        {
            var entity = dto.ToEntity(dto);
            _context.Teams.Add(entity);
            await _context.SaveChangesAsync();
            return entity.TeamId;
        }

        //public async Task SaveTeams(List<TeamDto> dto)
        //{
        //    foreach (TeamDto team in dto)
        //    {
        //        var entity = team.ToEntity(team);
        //        _context.Teams.Add(entity);
        //        await _context.SaveChangesAsync();
        //    }
        //}
    }
}
