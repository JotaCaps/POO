// See https://aka.ms/new-console-template for more information
using ExExceptions.Entities;
using ExExceptions.Entities.Exeptions;
using System.Globalization;
try
{

    Console.WriteLine("Enter Account Data: ");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial Balance: ");
    double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw Limit: ");
    double withdrwaLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new Account(number, holder, initialBalance, withdrwaLimit);

    Console.WriteLine();
    Console.Write("Enter the amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.Witdraw(amount);
    Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

}

catch(DomainException e) 
{
    Console.WriteLine("Withdraw error:" + e.Message);
}

