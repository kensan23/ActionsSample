using System;
using Xunit;
using Service;

namespace Service.Test
{
    public class BankAccountTest
    {

        private readonly BankAccount _account;

        [Fact]
        public void Withdraw_20_UpdatesBalance()
        {
            //arrange
            decimal startingAmount = 50m;
            decimal withdrawAmount = 20m;
            decimal expectedResult = 30m;
            BankAccount account = new BankAccount(startingAmount);
            //act
            account.Withdraw(withdrawAmount);

            //Assert
            Assert.Equal(expectedResult, account.balance);
        }

        [Fact]
        public void Deposit_20_UpdatesBalance()
        {
            //arrange
            decimal startingAmount = 20m;
            decimal depositAmount = 30m;
            decimal expectedResult = 50m;
            BankAccount account = new BankAccount(startingAmount);
            //act
            account.Deposit(depositAmount);

            //Assert
            Assert.Equal(expectedResult, account.balance);
        }

      [Fact]
        public void Withdraw_Exceeds_Balance()
        {
            //arrange
            decimal startingAmount = 20m;
            decimal withdrawAmount = 30m;
            BankAccount account = new BankAccount(startingAmount);
            //act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(withdrawAmount));
        }

    }
}
