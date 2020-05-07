using System;
using System.Globalization;

using Application.Exceptions;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter account data");
                System.Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                System.Console.Write("Holder: ");
                string name = Console.ReadLine();
                System.Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Witdraw limit: ");
                double witdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, balance, witdrawLimit);
                System.Console.Write("\nEnter the amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                System.Console.WriteLine("New balance: "
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                System.Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
