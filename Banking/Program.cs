using System;
using BankingKata.Presenters;
using BankingKata.Repositories;
using BankingKata.Services;

namespace BankingKata
{
    internal static class Program
    {
        internal static void Main()
        {
            AccountService account = new(new AccountRepository());
            account.Deposit(500, DateTime.Now);
            account.Deposit(1000, DateTime.Now);
            account.Withdraw(250, DateTime.Now);
            account.PrintStatement(new StatementPrinter());
        }
    }
}
