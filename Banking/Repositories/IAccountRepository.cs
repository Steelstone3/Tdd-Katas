using System;
using System.Collections.Generic;

namespace BankingKata.Repositories
{
    public interface IAccountRepository
    {
        List<ITransaction> Transactions { get; }
        void Deposit(uint amount, DateTime date);
        void Withdraw(uint amount, DateTime date);
    }
}