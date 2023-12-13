using Microsoft.AspNetCore.Mvc;
using benoit_Sorting_App.Models;
using Benoit_Sorting_App.Services.PlayerService;

namespace Benoit_Sorting_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _playerService;
        public PlayerController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public ActionResult<List<Player>> GetAllPlayersSortByScore()
        {
            var sortedPlayer = _playerService.GetAllPlayersSortByScore();
            return Ok(sortedPlayer);
        }

        [HttpGet("{playerAlias}")]
        public async Task<ActionResult<Player>> GetPlayerByAlias(String playerAlias)
        {
            var player = _playerService.GetPlayerByAlias(playerAlias);
            if(player is null)
            {
                return NotFound("There is no player with this name.");
            }
            return Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult<List<Player>>> AddNewPlayer(String newPlayerAlias)
        {
            var players = _playerService.AddNewPlayer(newPlayerAlias);
            if (players is null)
            {
                return BadRequest("There is already a player with that name.");
            }
            return Ok(players);
        }

        [HttpPut("{playerAlias}")]
        public ActionResult<Player> UpdatePlayerScore(String playerAlias, int playerScore)
        {
            var player = _playerService.UpdatePlayerScore(playerAlias, playerScore);
            if (player is null)
            {
                return NotFound("there's no player with that name.");
            }
            return Ok(player);
        }

        [HttpDelete]
        public ActionResult<List<Player>> DeleteAllPlayers()
        {
            var result = _playerService.DeleteAllPlayers();
            return Ok(result);
        }
    }
}