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

        // TODO : Check which best solution l28
        public List<Player> GetAllPlayersSortByScore()
        {
            //players.Sort((p1, p2) => p1.PlayerScore.CompareTo(p2.PlayerScore)).ToList();
            //players.Reverse();
            //return players;

            //return players.OrderByDescending(p => p.PlayerScore).ToList();
            return [.. players.OrderByDescending(p => p.PlayerScore)];
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

        //TODO : Exception rch in C# how to throw exception
        public List<Player> AddNewPlayer(string newPlayerAlias)
        {
            var player = players.Find(x => x.PlayerAlias == newPlayerAlias);
            if (player is not null)
            {
                throw new BadHttpRequestException("test");
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