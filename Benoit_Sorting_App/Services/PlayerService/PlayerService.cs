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

        public List<Player> AddNewPlayer(string newPlayerAlias)
        {
            throw new NotImplementedException();
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
    }
}