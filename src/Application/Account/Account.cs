namespace Application.Account
{
    // Abstraction: Abstract Class - provides common implementation for all accounts
    public abstract class Account : IAccount
    {
        // Encapsulation: _balance is protected, only accessible within class hierarchy
        protected double _balance;

        protected Account(double initialBalance)
        {
            // Encapsulation: Validate input to ensure object is always in a valid state
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(initialBalance, 0);
            _balance = initialBalance;
        }

        // Polymorphism: Overloading - multiple methods with the same name, different parameters
        public void Deposit(double amount)
        {
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(amount, 0);
            _balance += amount;
        }

        // Polymorphism: Overloading - convenience method for integer amounts
        public void Deposit(int amount)
        {
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(amount, 0);
            _balance += amount;
        }

        public double GetBalance() => _balance;

        // Polymorphism: Virtual method, can be overridden by derived classes
        public virtual void Withdraw(double amount)
        {
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(amount, 0);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(amount, _balance);
            _balance -= amount;
        }

        // Abstraction: Abstract method, must be implemented by derived classes
        public abstract string GetAccountType();
    }
}
