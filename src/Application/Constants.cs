namespace Application
{
    public static class Constants
    {
        public const double OverdraftLimit = -100;

        public static class AccountTypes
        {
            public const string Current = "Current";
            public const string Savings = "Savings";
        }

        public static class InitialBalances
        {
            public const double CurrentAccount = 1000;
            public const double SavingsAccount = 500;
        }

        public static class ErrorMessages
        {
            public const string NoWithdrawals = "No withdrawals from Savings";
            public const string OverdraftLimitExceeded = "Overdraft limit exceeded";
        }
    }
}
