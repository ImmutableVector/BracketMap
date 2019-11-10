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
    public class PlayerRepository : IPlayerRepository
    {
        private readonly BracketMapContext _context;

        public PlayerRepository(BracketMapContext context)
        {
            _context = context;
        }

        public async Task<int> SavePlayer(PlayerDto dto)
        {
            var entity = dto.ToEntity(dto);
            _context.Players.Add(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
    }
}
