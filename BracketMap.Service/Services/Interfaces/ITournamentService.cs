using BracketMap.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BracketMap.Business.Services.Interfaces
{
    public interface ITournamentService
    {
        Task<List<TournamentDto>> GetTournaments();
        Task<TournamentDto> GetTournamentById(int id);
        Task<int> SaveTournament(TournamentDto dto);
    }
}
