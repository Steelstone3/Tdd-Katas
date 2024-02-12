using System;
using BankingKata.Presenters;
using BankingKata.Repositories;

namespace BankingKata.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public void Deposit(uint amount, DateTime date)
        {
            accountRepository.Deposit(amount, date);
        }

        public void Withdraw(uint amount, DateTime date)
        {
            accountRepository.Withdraw(amount, date);
        }

        public void PrintStatement(IStatementPrinter statementPrinter)
        {
            statementPrinter.PrintStatement(accountRepository.Transactions);
        }
    }
}