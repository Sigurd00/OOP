using System;

namespace Banking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(100000, 6, 2);

            bankAccount.Deposit(5000);
            bankAccount.Withdraw(2000);
            bankAccount.Interests();
            Console.WriteLine(bankAccount.AccountBalance());

        }
    }
}