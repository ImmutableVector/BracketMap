//using BracketMap.DAL.Dtos;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using BracketMap.DAL.Repositories.Interfaces;
//using BracketMap.Business.Services.Interfaces;

//namespace BracketMap.Business.Services
//{
//    public class TournamentService : ITournamentService
//    {
//        private readonly ITournamentRepository _tournamentRepository;

//        public TournamentService(ITournamentRepository tournamentRepository)
//        {
//            _tournamentRepository = tournamentRepository;
//        }

//        public async Task<List<TournamentDto>> GetTournaments()
//            => await _tournamentRepository.GetTournaments();

//        public async Task<TournamentDto> GetTournamentById(int id)
//            => await _tournamentRepository.GetTournamentById(id);

//        public async Task<int> SaveTournament(TournamentDto dto)
//            => await _tournamentRepository.SaveTournament(dto);
//    }
//}
