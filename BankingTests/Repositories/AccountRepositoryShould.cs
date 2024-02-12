using System;
using BankingKata.Repositories;
using Xunit;

namespace BankingKataTests.Repositories
{
    public class AccountRepositoryShould
    {
        private readonly IAccountRepository accountRepository = new AccountRepository();

        [Fact]
        public void Construct()
        {
            // Then
            Assert.NotNull(accountRepository.Transactions);
        }

        [Fact]
        public void MakeADeposit()
        {
            // Arrange
            DateTime date = DateTime.Now;
            const int balance = 500;
            const int amountOutput = 500;
            const uint amountInput = 500;

            // Act
            accountRepository.Deposit(amountInput, date);

            // Assert
            Assert.NotEmpty(accountRepository.Transactions);
            Assert.Equal(balance, accountRepository.Transactions[0].Balance);
            Assert.Equal(amountOutput, accountRepository.Transactions[0].Amount);
            Assert.Equal(date, accountRepository.Transactions[0].Date);
        }

        [Fact]
        public void MakeAWithdrawal()
        {
            // Arrange
            DateTime date = DateTime.Now;
            const int balance = -500;
            const int amountOutput = -500;
            const uint amount = 500;

            // Act
            accountRepository.Withdraw(amount, date);

            // Assert
            Assert.NotEmpty(accountRepository.Transactions);
            Assert.Equal(balance, accountRepository.Transactions[0].Balance);
            Assert.Equal(amountOutput, accountRepository.Transactions[0].Amount);
        }

        [Fact]
        public void Acceptance()
        {
            // Arrange
            DateTime date = DateTime.Now;
            const uint amount = 500;

            // Act
            accountRepository.Deposit(amount, date);
            accountRepository.Deposit(amount, date);
            accountRepository.Deposit(250, date);
            accountRepository.Withdraw(amount, date);

            // Assert
            Assert.NotEmpty(accountRepository.Transactions);
            Assert.Equal(500, accountRepository.Transactions[0].Balance);
            Assert.Equal(500, accountRepository.Transactions[0].Amount);
            Assert.Equal(date, accountRepository.Transactions[0].Date);
            Assert.Equal(1000, accountRepository.Transactions[1].Balance);
            Assert.Equal(500, accountRepository.Transactions[1].Amount);
            Assert.Equal(date, accountRepository.Transactions[1].Date);
            Assert.Equal(1250, accountRepository.Transactions[2].Balance);
            Assert.Equal(250, accountRepository.Transactions[2].Amount);
            Assert.Equal(date, accountRepository.Transactions[2].Date);
            Assert.Equal(750, accountRepository.Transactions[3].Balance);
            Assert.Equal(-500, accountRepository.Transactions[3].Amount);
            Assert.Equal(date, accountRepository.Transactions[3].Date);
        }
    }
}