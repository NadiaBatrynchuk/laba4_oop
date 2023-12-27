using Lab3.DB.Service.Stats;
using Lab3.Printer;

namespace Lab4.Command
{
    class ShowAllGames : IMenu
    {
        GameStatsService gameStatsService;
        public ShowAllGames(GameStatsService gameStatsService)
        {
            this.gameStatsService = gameStatsService;
        }

        public void showAllGames()
        {
            Console.WriteLine($"Printing all games...");
            Printer.ShowAllGames(gameStatsService.ReadGames());
        }
    }
}
