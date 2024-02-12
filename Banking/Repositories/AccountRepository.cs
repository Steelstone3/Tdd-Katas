using System;
using System.Collections.Generic;

namespace BankingKata.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private int balance;
        public List<ITransaction> Transactions { get; } = new List<ITransaction>();

        public void Deposit(uint amount, DateTime date)
        {
            balance += (int)amount;
            Transaction transaction = new(date, balance, (int)amount);
            Transactions.Add(transaction);
        }

        public void Withdraw(uint amount, DateTime date)
        {
            balance -= (int)amount;
            Transaction transaction = new(date, balance, -(int)amount);
            Transactions.Add(transaction);
        }
    }
}