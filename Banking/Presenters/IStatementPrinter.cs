using System.Collections.Generic;
using BankingKata.Repositories;

namespace BankingKata.Presenters
{
    public interface IStatementPrinter
    {
        void PrintStatement(IEnumerable<ITransaction> transactions);
    }
}