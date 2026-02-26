namespace Application.Account
{
    // Inheritance: CurrentAccount inherits from Account
    public class CurrentAccount(double initialBalance = 0) : Account(initialBalance)
    {
        // Polymorphism: Overriding - provides specific implementation for CurrentAccount
        public override void Withdraw(double amount)
        {
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(amount, 0);
            double newBalance = _balance - amount;

            if (newBalance < Constants.OverdraftLimit)
                throw new InvalidOperationException(Constants.ErrorMessages.OverdraftLimitExceeded);

            _balance = newBalance;
        }

        // Polymorphism: Overriding - implements abstract method
        public override string GetAccountType() => Constants.AccountTypes.Current;
    }
}
