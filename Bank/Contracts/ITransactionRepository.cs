using System.Collections.Generic;
using Bank;

namespace Bank.Contracts
{
    public interface ITransactionRepository
    {
        void AddDeposit(int amount);
        void AddWithdrawal(int amount);
        List<Transaction> AllTransactions();
    }
}