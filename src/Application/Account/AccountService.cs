namespace Application.Account
{
    public class AccountService
    {
        public static void ProcessAccounts(IAccount[] accounts)
        {
            foreach (IAccount account in accounts)
            {
                // Polymorphism: Treats all accounts uniformly via IAccount interface
                Console.WriteLine($"{account.GetAccountType()}: {account.GetBalance():F2}");
                account.Deposit(100.5);  // Uses double overload
                account.Deposit(50);     // Uses int overload

                try
                {
                    account.Withdraw(200); // Calls overridden Withdraw method
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  {ex.Message}");
                }

                Console.WriteLine($"Final: {account.GetBalance():F2}\n");
            }
        }
    }
}
