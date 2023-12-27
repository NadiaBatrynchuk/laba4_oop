using Lab2.Accounts;
using Lab3.DB.Service.Accounts;

namespace Lab4.Command
{
    public class AddNewPlayer : IMenu
    {
        AccountService accountService;
        public AddNewPlayer(AccountService accountService)
        {
            this.accountService = accountService;
        }

        public void addNewPlayer(string UserName, AccountType Type)
        {
            Console.WriteLine("Adding new player...");
            var tmpAccs = accountService.ReadAccountByUserName(UserName);
            if (tmpAccs.Count != 0)
            {
                Console.WriteLine("Player with this name are already exist.");
                return;
            }
            GameAccount account = new AccountFactory().CreateAccount(AccountType.Standard, UserName, 0, 0);
            accountService.CreateAccount(account);
            Console.WriteLine("New player added successfully!");
        }
    }
}
