namespace Application.Account
{
    // Abstraction: Interface - defines a contract for all account types
    public interface IAccount
    {
        void Deposit(double amount);
        void Deposit(int amount);
        void Withdraw(double amount);
        double GetBalance();
        string GetAccountType();
    }
}
