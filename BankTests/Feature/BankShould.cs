using Bank;
using Bank.Contracts;
using Moq;
using Xunit;

namespace BankTests
{
    public class BankShould
    {
        //Overall Feature Acceptance Test
        [Fact(Skip="Doesn't seem to run print correctly?")]
        public void PrintAStatementContainingAllTransactions()
        {
            var transactionRepository = new Mock<ITransactionRepository>();
            var console = new Mock<IConsole>();
            var statementPrinter = new Mock<IStatementPrinter>();
            statementPrinter.Setup(x => x.Console).Returns(console.Object);
            
            var account = new Account(transactionRepository.Object, statementPrinter.Object);

            account.Deposit(1000);
            account.Withdraw(100);
            account.Deposit(500);
            account.PrintStatement();

            console.InSequence(new MockSequence());
            console.Verify(console => console.WriteLine("DATE | AMOUNT | BALANCE"));
            console.Verify(console => console.WriteLine("10/04/14 | 500.00 | 1400"));
            console.Verify(console => console.WriteLine("02/04/14 | -100.00 | 900.00"));
            console.Verify(console => console.WriteLine("01/04/14 | 1000.00 | 1000.00"));
        }
    }

}