using Lab3.DB.Service.Accounts;
using Lab3.DB.Service.Stats;


namespace Lab4.Command
{
    public class MenuFactory
    {
        public static IMenu? Detrmine(string command, AccountService accountService, GameStatsService gameStatsService)
        {
            switch (command)
            {
                case "show_players":
                    return new ShowPlayers(accountService);
                case "add_player":
                    return new AddNewPlayer(accountService);
                case "show_player_stats":
                    return new ShowPlayerStats(gameStatsService);
                case "play_game":
                    return new PlayGame(gameStatsService);
                case "show_all_games":
                    return new ShowAllGames(gameStatsService);
                default:
                    Console.WriteLine("Invalid command.");
                    return null;
            }
        }
    }
}
