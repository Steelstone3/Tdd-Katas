using System;

namespace Bank
{
    public class Transaction
    {
        public Transaction(DateTime date, int amount)
        {
            Date = date;
            Amount = amount;
        }

        public DateTime Date { get; private set; }
        public int Amount { get; private set; }
    }
}