using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BracketMap.DAL.Models;
using BracketMap.DAL.Dtos;
using BracketMap.Business.Services.Interfaces;

namespace BracketMap.Web.Controllers
{
    [Route("player")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostPlayer(PlayerDto dto)
        => Ok(await _playerService.SavePlayer(dto));

    }
}
