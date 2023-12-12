using benoit_Sorting_App.Models;

namespace Benoit_Sorting_App.Services.PlayerService
{
    public class PlayerService : IPlayerService
    {
        private static List<Player> players = new List<Player>
        {
            new Player
            {
                PlayerAlias = "Test",
                TournamentPlace = 34
            }
        };


    }
}