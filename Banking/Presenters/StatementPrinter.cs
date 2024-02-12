using System.Collections.Generic;
using System.Linq;
using BankingKata.Repositories;
using Spectre.Console;

namespace BankingKata.Presenters
{
    public class StatementPrinter : IStatementPrinter
    {
        public void PrintStatement(IEnumerable<ITransaction> transactions)
        {
            Table table = CreateTable();
            WriteRows(transactions, table);
            AnsiConsole.Write(table);
        }

        private static Table CreateTable()
        {
            Table table = new()
            {
                Title = new TableTitle("Account")
            };

            table.AddColumn("Date");
            table.AddColumn("Amount");
            table.AddColumn("Balance");

            return table;
        }

        private static void WriteRows(IEnumerable<ITransaction> transactions, Table table)
        {
            for (int i = transactions.Count() - 1; i >= 0; i--)
            {
                table.AddRow($"{transactions.ToArray()[i].Date}", $"{transactions.ToArray()[i].Amount}", $"{transactions.ToArray()[i].Balance}");
            }
        }
    }
}