using Application;
using Application.Account;

IAccount[] accounts =
[
    new CurrentAccount(Constants.InitialBalances.CurrentAccount),  // Inheritance: CurrentAccount is a Account
    new SavingsAccount(Constants.InitialBalances.SavingsAccount)   // Inheritance: SavingsAccount is a Account
];

AccountService.ProcessAccounts(accounts);
