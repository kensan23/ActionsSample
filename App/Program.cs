using System;
using Service;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            //starting balance 100
            BankAccount account = new BankAccount(100m);
            Console.WriteLine(String.Format("Your balance is {0}", account.balance));
            Console.WriteLine("Withdrawing 20");
            account.Withdraw(20m);
            Console.WriteLine(String.Format("Your balance is {0}", account.balance));

        }
    }
}
