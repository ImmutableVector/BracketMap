using BracketMap.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BracketMap.DAL.Repositories.Interfaces;
using BracketMap.Business.Services.Interfaces;

namespace BracketMap.Business.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<int> SavePlayer(PlayerDto dto)
            => await _playerRepository.SavePlayer(dto);
    }
}
