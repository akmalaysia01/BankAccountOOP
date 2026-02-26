namespace Application.Account
{
    // Inheritance: SavingsAccount inherits from Account
    public class SavingsAccount(double initialBalance = 0) : Account(initialBalance)
    {
        // Polymorphism: Overriding - provides specific implementation for SavingsAccount
        public override void Withdraw(double amount)
        {
            throw new InvalidOperationException(Constants.ErrorMessages.NoWithdrawals);
        }

        // Polymorphism: Overriding - implements abstract method
        public override string GetAccountType() => Constants.AccountTypes.Savings;
    }
}
