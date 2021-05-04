using System;
using System.Collections.Generic;
using Bank.Contracts;

namespace Bank
{
    public class StatementPrinter : IStatementPrinter
    {
        public IConsole Console { get; set; }

        private string _statementHeader = "DATE | AMOUNT | BALANCE";

        public StatementPrinter(IConsole console)
        {
            Console = console;
        }

        public void Print(List<Transaction> transactions)
        {
            Console.WriteLine(_statementHeader);

            foreach (var line in AddStatements(transactions))
            {
                Console.WriteLine(line);
            }
        }

        private List<string> AddStatements(List<Transaction> transactions)
        {
            int runningBalance = 0;
            var printedLines = new List<string>();

            foreach (var transaction in transactions)
            {
                runningBalance += transaction.Amount;
                printedLines.Add(StatementLine(transaction, runningBalance));
            }

            printedLines.Reverse();
            return printedLines;
        }

        private string StatementLine(Transaction transaction, int runningBalance)
        {
            return transaction.Date.ToString() + " | " + string.Format("{0:0.00}", transaction.Amount) + " | " + string.Format("{0:0.00}", runningBalance);
        }
    }
}