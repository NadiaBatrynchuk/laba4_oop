using Lab2.Accounts;
using Lab2.Games;
using Lab3.DB.Service.Stats;

namespace Lab4.Command
{
    public class PlayGame : IMenu
    {
        GameStatsService gameStatsService;
        public PlayGame(GameStatsService gameStatsService)
        {
            this.gameStatsService = gameStatsService;
        }

        public void playGame(GameAccount player1, GameAccount player2, GameType Type, int rating)
        {
            Console.WriteLine("Playing game...");
            BasicGame game = new GameFactory().CreateGame(Type);
            game.PlayGame(player1, player2, gameStatsService, rating);
            Console.WriteLine("Game over!");
        }
    }
}
