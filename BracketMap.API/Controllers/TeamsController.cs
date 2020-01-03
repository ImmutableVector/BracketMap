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
    [Route("team")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostTeam()
        => Ok(await _teamService.SaveTeam());


    }
}
