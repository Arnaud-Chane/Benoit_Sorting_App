using Microsoft.AspNetCore.Mvc;
using benoit_Sorting_App.Models;
using Benoit_Sorting_App.Services.PlayerService;

namespace Benoit_Sorting_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        //TODO : create service where logic belong
        //TODO : Remove async 
        // TODO : {} in if
        // TODO : YAGNI l.33 remove ThenBy

        private static List<Player> emptyPlayers = new List<Player>();
        private static List<Player> players = new List<Player>
        {
            new Player
            {
                PlayerAlias = "Test",
                TournamentPlace = 34
            }
        };

        private readonly PlayerService _playerService;
        public PlayerController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetAllPlayersSortByScore()
        {
            var sortedPlayer = _playerService.GetAllPlayersSortByScore();
            return Ok(sortedPlayer);
        }

        //TODO : GetPlayerByAlias remove generic term Data
        [HttpGet("{playerAlias}")]
        public async Task<ActionResult<Player>> GetPlayerByAlias(String playerAlias)
        {
            var player = players.Find(x => x.PlayerAlias == playerAlias);
            if (player is null)
            {
                return NotFound("There is no player with that name.");
            }
            return Ok(player);
        }

        // TODO : check player Alias before adding one
        // TODO :  rename method and parameter
        // 
        [HttpPost]
        public async Task<ActionResult<List<Player>>> AddNewPlayer(String newPlayerAlias)
        {
            var player = _playerService.AddNewPlayer(newPlayerAlias);
            if (player is null)
            {
                return BadRequest("There is already a player with that name.");
            }
            return Ok(player);
        }

        [HttpPut("{playerAlias}")]
        public async Task<ActionResult<Player>> UpdatePlayerScore(String playerAlias, int playerScore)
        {
            var player = players.Find(x => x.PlayerAlias == playerAlias);
            if (player is null)
            {
                return NotFound("there's no player with that name.");
            }
            player.PlayerScore = playerScore;
            return Ok(player);
        }

        //TODO : modif type of return
        [HttpDelete]
        public IActionResult DeleteAllPlayers()
        {
            players.Clear();
            return Ok(players);
        }
    }
}