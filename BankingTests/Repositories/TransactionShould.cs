using System;
using BankingKata.Repositories;
using Xunit;

namespace BankingKataTests.Repositories
{
    public class TransactionShould
    {
        [Fact]
        public void Construct()
        {
            // Arrange
            const int balance = 1000;
            const int amount = -500;
            DateTime dateTime = DateTime.Now;
            ITransaction transaction = new Transaction(dateTime, balance, amount);

            // Assert
            Assert.Equal(dateTime, transaction.Date);
            Assert.Equal(balance, transaction.Balance);
            Assert.Equal(amount, transaction.Amount);
        }
    }
}