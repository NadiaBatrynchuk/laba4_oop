using Lab2.Accounts;
using Lab3.DB.Service.Accounts;
using Lab3.Printer;

namespace Lab4.Command
{
    public class ShowPlayers : IMenu
    {
        private List<GameAccount> accounts;

        public ShowPlayers(AccountService accountService)
        {
            accounts = accountService.ReadAccounts();
        }

        public void showPlayers()
        {
            Console.WriteLine("Printing all players...");
            Printer.ShowAllPlayers(accounts);
        }
    }
}
