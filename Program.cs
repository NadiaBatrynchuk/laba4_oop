using Lab3.DB;
using Lab3.DB.Service.Accounts;
using Lab3.DB.Service.Stats;
using Lab4.Command;

class Program
{
    static void Main(string[] args)
    {
        DbContext context = new();
        GameStatsService gameStatsService = new(context);
        AccountService accountService = new(context);
        IMenu? menu = null;
        string? command = "";

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Commands: ");
        Console.WriteLine("play_game - зіграти в гру");
        Console.WriteLine("add_player - додати нового гравця");
        Console.WriteLine("show_players - показати усіх гравців");
        Console.WriteLine("show_all_games - показати статистику усіх ігор");
        Console.WriteLine("show_player_stats - показати статистику усіх ігор гравця");
        Console.WriteLine("exit - вихід з програми\n");

        while(true)
        {
            try
            {
                Console.Write("input>> ");
                command = Console.ReadLine();

                if(command == "exit")
                    break;

                if (command != null && command != "")
                {
                    menu = MenuFactory.Detrmine(command, accountService, gameStatsService);
                    if(menu != null)
                        menu.Execute(command, accountService);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error: " + exc.ToString());
            }
        }
    }
}
    