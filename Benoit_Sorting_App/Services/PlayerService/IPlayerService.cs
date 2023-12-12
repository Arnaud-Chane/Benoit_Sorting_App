namespace Benoit_Sorting_App.Services.PlayerService
{
    public interface IPlayerService
    {
        List<Player> GetAllPlayersSortByScore();
        Player GetPlayerByAlias(String playerAlias);
        List<Player> AddNewPlayer(String newPlayerAlias);
        Player UpdatePlayerScore(String playerAlias, int playerScore);
        DeleteAllPlayers();
    }
}
