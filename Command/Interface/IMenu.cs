using Lab2.Accounts;
using Lab2.Games;
using Lab3.DB.Service.Accounts;

namespace Lab4.Command
{
    public interface IMenu
    {
        public void showPlayers()
        {
            throw new NotSupportedException();
        }

        public void addNewPlayer(string UserName, AccountType Type)
        {
            throw new NotSupportedException();
        }

        public void showPlayerGames(string UserName)
        {
            throw new NotSupportedException();
        }

        public void showAllGames()
        {
            throw new NotSupportedException();
        }

        public void playGame(GameAccount player1, GameAccount player2, GameType Type, int rating)
        {
            throw new NotSupportedException();
        }

        public void Execute(string command, AccountService accountService)
        {
            string? usrName;
            string? usrName1;
            string? usrName2;
            string? accountType;
            string? gameType;
            string? gameRating;

            switch (command)
            {
                case "show_players":
                    showPlayers();
                    break;
                case "add_player":
                    Console.Write("Player name: ");
                    usrName = Console.ReadLine();
                    Console.Write("Account type: ");
                    accountType = Console.ReadLine();
                    if (usrName != null && accountType != null && usrName != "" && accountType != "")
                    {
                        AccountType type = (AccountType)Enum.Parse(typeof(AccountType), accountType);
                        addNewPlayer(usrName, type);
                    }
                    break;
                case "show_player_stats":
                    Console.Write("Player name: ");
                    usrName = Console.ReadLine();
                    if (usrName != null && usrName != "")
                        showPlayerGames(usrName);
                    break;
                case "show_all_games":
                    showAllGames();
                    break;
                case "play_game":
                    Console.Write("Player1 name: ");
                    usrName1 = Console.ReadLine();
                    Console.Write("Player2 name: ");
                    usrName2 = Console.ReadLine();
                    Console.Write("Game type: ");
                    gameType = Console.ReadLine();
                    Console.Write("Game rating: ");
                    gameRating = Console.ReadLine();
                    if (usrName1 != null && usrName2 != null && gameType != null && gameRating != null &&
                        usrName1 != "" && usrName2 != "" && gameType != "" && gameRating != "")
                    {
                        GameAccount player1 = accountService.ReadAccountByUserName(usrName1)[0];
                        GameAccount player2 = accountService.ReadAccountByUserName(usrName2)[0];
                        GameType type = (GameType)Enum.Parse(typeof(GameType), gameType);
                        int rating = int.Parse(gameRating);
                        if (player1 != null && player2 != null)
                            playGame(player1, player2, type, rating);
                    }
                    break;
            }
        }
    }
}