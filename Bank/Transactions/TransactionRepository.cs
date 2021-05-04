using System.Collections.Generic;
using Bank.Contracts;

namespace Bank
{
    public class TransactionRepository : ITransactionRepository
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public void AddDeposit(int amount)
        {
            _transactions.Add(new Transaction(new System.DateTime().Date, amount));
        }

        public void AddWithdrawal(int amount)
        {
            _transactions.Add(new Transaction(new System.DateTime().Date, amount));
        }

        public List<Transaction> AllTransactions()
        {
            return _transactions;
        }
    }
}