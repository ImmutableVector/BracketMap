using BracketMap.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BracketMap.DAL.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Task<int> SavePlayer(PlayerDto dto);
    }
}
