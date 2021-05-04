using System.Collections.Generic;
using Bank;
using Bank.Contracts;
using Moq;
using Xunit;

namespace BankTests
{
    public class AccountShould
    {
        private Mock<IStatementPrinter> _statementPrinter = new Mock<IStatementPrinter>();
        private Mock<ITransactionRepository> _transactionRepository = new Mock<ITransactionRepository>();
        Account _account;

        public AccountShould()
        {
            _account = new Account(_transactionRepository.Object, _statementPrinter.Object);
        }

        [Fact]
        public void StoreADepositTransaction()
        {
            _account.Deposit(100);

            _transactionRepository.Verify(transactionRepository => transactionRepository.AddDeposit(100));
        }

        [Fact]
        public void StoreAWithdrawTransaction()
        {
            _account.Withdraw(100);

            _transactionRepository.Verify(transactionRepository => transactionRepository.AddWithdrawal(100));
        }

        [Fact]
        public void PrintAStatement()
        {
            var transactions = new List<Transaction>();
            _transactionRepository.Setup(x => x.AllTransactions()).Returns(transactions);

            _account.PrintStatement();

            _statementPrinter.Verify(x => x.Print(transactions));
        }
    }
}
