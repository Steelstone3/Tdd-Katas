using System;

namespace BankingKata.Repositories
{
    public interface ITransaction
    {
        DateTime Date { get; }
        int Balance { get; }
        int Amount { get; }
    }
}