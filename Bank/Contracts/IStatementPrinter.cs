using System.Collections.Generic;

namespace Bank.Contracts
{
    public interface IStatementPrinter
    {
        IConsole Console { get; set; }

        void Print(List<Transaction> transactions);
    }
}