using benoit_Sorting_App.Models;
using Microsoft.AspNetCore.Mvc;


namespace Benoit_Sorting_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController
    {
        private static List<Player> players = new List<Player>();
        [HttpPost]
        public async Task<ActionResult<List<Player>>> AddNewPlayer(String newPlayerAlias)
        {
            Player newPlayer = CreatePlayer(newPlayerAlias, players.Count());

            players.Add(newPlayer);
            return players;
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
    }
}