
using Lab3.DB.Service.Stats;
using Lab3.Printer;

namespace Lab4.Command
{
    public class ShowPlayerStats : IMenu
    {
        GameStatsService gameStatsService;
        public ShowPlayerStats(GameStatsService gameStatsService)
        {
            this.gameStatsService = gameStatsService;
        }

        public void showPlayerGames(string UserName)
        {
            Console.WriteLine($"Printing all '{UserName}' games...");
            Printer.ShowAllGames(gameStatsService.ReadGamesByPlayerName(UserName));
        }
    }
}
