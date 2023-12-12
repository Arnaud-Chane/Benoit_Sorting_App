using benoit_Sorting_App.Models;

namespace Benoit_Sorting_App.Services.PlayerService
{
    public class PlayerService
    {
                private static List<Player> players = new List<Player>
        {
            new Player
            {
                PlayerAlias = "Test",
                TournamentPlace = 34
            }
        };

        public List<Player> AddNewPlayer(string newPlayerAlias)
        {
            var player = players.Find(x => x.PlayerAlias == newPlayerAlias);
            if (player is not null)
            {
                //TODO : Find what to return
                return "There is already a player with that name.";
            }
            Player newPlayer = CreatePlayer(newPlayerAlias);

            players.Add(newPlayer);
            return players;
        }

        public List<Player> GetAllPlayersSortByScore()
        {
            throw new NotImplementedException();
        }

        public Player GetPlayerByAlias(string playerAlias)
        {
            throw new NotImplementedException();
        }

        public Player UpdatePlayerScore(string playerAlias, int playerScore)
        {
            throw new NotImplementedException();
        }

        private Player CreatePlayer(string playerAlias)
        {
            Player player = new Player
            {
                PlayerAlias = playerAlias,
            };
            return player;
        }
    }
}