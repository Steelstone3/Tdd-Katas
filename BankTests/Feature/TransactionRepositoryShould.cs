using System;
using System.Collections.Generic;
using Bank;
using Bank.Contracts;
using Moq;
using Xunit;

namespace BankTests
{
    public class TransactionRepositoryShould
    {
        private TransactionRepository transactionRepository = new TransactionRepository();
        private DateTime _date = new DateTime().Date;

        [Theory]
        [InlineData(100)]
        [InlineData(500)]
        public void CreateAndStoreADepositTransaction(int amount)
        {
            transactionRepository.AddDeposit(amount);
            var transactions = transactionRepository.AllTransactions();

            Assert.Equal(1, transactions.Count);
            Assert.Equal(Transaction(_date, amount).Date, transactions[0].Date );
            Assert.Equal(Transaction(_date, amount).Amount, transactions[0].Amount );
        }

        [Theory]
        [InlineData(100)]
        [InlineData(500)]
        public void CreateAndStoreAWithdrawalTransaction(int amount)
        {
            transactionRepository.AddWithdrawal(amount);
            var transactions = transactionRepository.AllTransactions();

            Assert.Equal(1, transactions.Count);
            Assert.Equal(Transaction(_date, amount).Date, transactions[0].Date );
            Assert.Equal(Transaction(_date, amount).Amount, transactions[0].Amount );
        }

        private Transaction Transaction(DateTime date, int amount) => new Transaction(date, amount);
    }
}