using benoit_Sorting_App.Models;
namespace Benoit_Sorting_App.Services.PlayerService
{
    public class PlayerService
    {
        private static List<Player> emptyPlayers = new List<Player>();
        private static List<Player> players = new List<Player>
        {
            new Player
            {
                PlayerAlias = "Test",
                TournamentPlace = 34
            },
            new Player
            {
                PlayerAlias = "Test2",
                TournamentPlace = 10
            }
        };

        public List<Player> GetAllPlayersSortByScore()
        {
            List<Player> sortedPlayer = players;
            sortedPlayer.Sort((p1, p2) => p1.PlayerScore.CompareTo(p2.PlayerScore));
            sortedPlayer.Reverse();
            return sortedPlayer;
        }

        public Player GetPlayerByAlias(string playerAlias)
        {
            var player = players.Find(x => x.PlayerAlias == playerAlias);
            if (player is null)
            {
                return null;
            }
            return player;
        }

        //TODO : switch null to what
        public List<Player> AddNewPlayer(string newPlayerAlias)
        {
            var player = players.Find(x => x.PlayerAlias == newPlayerAlias);
            if (player is not null)
            {
                //TODO : Find what to return
                //return "There is already a player with that name.";
                return null;
            }
            Player newPlayer = CreatePlayer(newPlayerAlias);

            players.Add(newPlayer);
            return players;
        }

        public Player UpdatePlayerScore(string playerAlias, int playerScore)
        {
            var player = players.Find(x => x.PlayerAlias == playerAlias);
            if (player is null)
            {
                return null;
            }
            player.PlayerScore = playerScore;
            return player;
        }

        public List<Player> DeleteAllPlayers()
        {
            players.Clear();
            return players;
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