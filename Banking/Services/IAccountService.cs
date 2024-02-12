using System;
using BankingKata.Presenters;
using BankingKata.Repositories;

namespace BankingKata.Services
{
    public interface IAccountService
    {
        void Deposit(uint amount, DateTime date);
        void Withdraw(uint amount, DateTime date);
        void PrintStatement(IStatementPrinter statementPrinter);
    }
}