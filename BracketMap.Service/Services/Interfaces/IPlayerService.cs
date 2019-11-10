using BracketMap.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BracketMap.Business.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<int> SavePlayer(PlayerDto dto);
    }
}
