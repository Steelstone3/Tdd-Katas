using Bank.Contracts;

namespace Bank
{
    public class Account
    {
        private ITransactionRepository _transactionRepository;
        private IStatementPrinter _statementPrinter;

        public Account(ITransactionRepository transactionRepository, IStatementPrinter statementPrinter)
        {
            _transactionRepository = transactionRepository;
            _statementPrinter = statementPrinter;
        }

        public void Deposit(int amount)
        {
            _transactionRepository.AddDeposit(amount);
        }

        public void Withdraw(int amount)
        {
            _transactionRepository.AddWithdrawal(amount);
        }

        public void PrintStatement()
        {
           _statementPrinter.Print(_transactionRepository.AllTransactions());
        }
    }

}