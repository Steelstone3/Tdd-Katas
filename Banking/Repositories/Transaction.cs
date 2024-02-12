using System;

namespace BankingKata.Repositories
{
    public class Transaction : ITransaction
    {
        public Transaction(DateTime date, int balance, int amount)
        {
            Date = date;
            Balance = balance;
            Amount = amount;
        }

        public DateTime Date { get; }
        public int Balance { get; }
        public int Amount { get; }
    }
}