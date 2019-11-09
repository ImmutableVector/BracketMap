using BracketMap.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BracketMap.DAL.Repositories.Interfaces;
using BracketMap.Business.Services.Interfaces;

namespace BracketMap.Business.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<int> SaveTeam(TeamDto dto)
            => await _teamRepository.SaveTeam(dto);
    }
}
