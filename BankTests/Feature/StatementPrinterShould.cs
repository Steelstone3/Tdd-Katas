using System;
using System.Collections.Generic;
using Bank;
using Bank.Contracts;
using Moq;
using Xunit;

namespace BankTests
{
    public class StatementPrinterShould
    {
        private Mock<IConsole> _console = new Mock<IConsole>();
        
        [Fact]
        public void AlwaysPrintTheHeader()
        {
            var statmentPrinter = new StatementPrinter(_console.Object);

            statmentPrinter.Print(new List<Transaction>());

            _console.Verify(x => x.WriteLine("DATE | AMOUNT | BALANCE"));
        }

        [Fact]
        public void PrintTransactionsInReverseChronologicalOrder()
        {
            var statmentPrinter = new StatementPrinter(_console.Object);

            var transactions = new List<Transaction>()
            {
                //deposit
                new Transaction(DateTime.UtcNow, 1000),
                //withdrawal
                new Transaction(DateTime.UtcNow, -100),
                //deposit
                new Transaction(DateTime.UtcNow, 500),
            };

            statmentPrinter.Print(transactions);

            _console.InSequence(new MockSequence());
            _console.Verify(console => console.WriteLine("DATE | AMOUNT | BALANCE"));
            _console.Verify(console => console.WriteLine($"{DateTime.UtcNow} | 500.00 | 1400.00"));
            _console.Verify(console => console.WriteLine($"{DateTime.UtcNow} | -100.00 | 900.00"));
            _console.Verify(console => console.WriteLine($"{DateTime.UtcNow} | 1000.00 | 1000.00"));
        }
    }

}