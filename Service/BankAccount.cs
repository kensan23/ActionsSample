using System;

namespace Service
{
    public class BankAccount
    {
        public decimal balance { get; private set; }
        public BankAccount(decimal startingBalance)
        {
            if (startingBalance < 0)
            {
                throw new ArgumentOutOfRangeException("Starting balance must be positive");
            }
            this.balance = startingBalance;

        }

        public decimal Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException("Insufficient funds");
            }
            else if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount must be positive");
            }
            else
            {
                balance += amount;
            }
            return balance;
        }

        public decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount must be positive");
            }
            balance += amount;
            return balance;
        }

    }
}
