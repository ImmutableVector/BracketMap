using BracketMap.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BracketMap.DAL.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Task<int> SaveTeam();
    }
}
