using System;
using BankingKata.Presenters;
using BankingKata.Repositories;
using BankingKata.Services;
using Moq;
using Xunit;

namespace BankingKataTests
{
    public class AccountServiceShould
    {
        private readonly Mock<IStatementPrinter> statementPrinter = new();
        private readonly Mock<IAccountRepository> accountRepository = new();
        private readonly IAccountService account;

        public AccountServiceShould()
        {
            account = new AccountService(accountRepository.Object);
        }

        [Fact]
        public void MakeADeposit()
        {
            // Act
            DateTime date = DateTime.Now;
            const uint amount = 500;
            accountRepository.Setup(ar => ar.Deposit(amount, date));

            // Arrange
            account.Deposit(amount, date);

            // Assert
            accountRepository.VerifyAll();
        }

        [Fact]
        public void MakeAWithdrawal()
        {
            // Act
            DateTime date = DateTime.Now;
            const uint amount = 500;
            accountRepository.Setup(ar => ar.Withdraw(amount, date));

            // Arrange
            account.Withdraw(amount, date);

            // Assert
            accountRepository.VerifyAll();
        }

        [Fact]
        public void PrintAStatement()
        {
            // Act
            statementPrinter.Setup(sp => sp.PrintStatement(accountRepository.Object.Transactions));

            // Arrange
            account.PrintStatement(statementPrinter.Object);

            // Assert
            statementPrinter.VerifyAll();
        }
    }
}