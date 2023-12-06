using benoit_Sorting_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Collections;

namespace Benoit_Sorting_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        //private static List<Player> players = new List<Player>();
        private static List<Player> players = new List<Player>
        {
            new Player
            {
                Id = 1,
                PlayerAlias = "Test",
                TournamentPlace = 34
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetAllPlayersSortByScore()
        {
            return Ok("ok");
        }

        [HttpGet("{playerAlias}")]
        public async Task<ActionResult<Player>> GetPlayerData(String playerAlias)
        {
            var player = players.Find(x => x.PlayerAlias == playerAlias);
            if (player is null)
                return NotFound("there's no player with that name.");
            return Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult<List<Player>>> AddNewPlayer(String newPlayerAlias)
        {
            Player newPlayer = CreatePlayer(newPlayerAlias, players.Count());

            players.Add(newPlayer);
            return Ok(players);
        }

        [HttpPut("{playerAlias}")]
        public async Task<ActionResult<Player>> UpdatePlayerScore(String playerAlias, int playerScore)
        {
            var player = players.Find(x => x.PlayerAlias == playerAlias);
            if (player is null)
                return NotFound("there's no player with that name.");
            player.PlayerScore = playerScore;
            return Ok(player);
        }


        private Player CreatePlayer(string playerAlias, int id)
        {
            Player player = new Player
            {
                PlayerAlias = playerAlias,
                Id = id
            };
            return player;
        }

        private class ComparePlayers : IComparer
        {
            public int Compare(object? x, object? y)
            {
                return (new CaseInsensitiveComparer()).Compare(((Player)x).PlayerScore,
                       ((Player)y).PlayerScore);
            }
        }
    }
}