// See https://aka.ms/new-console-template for more information
using System.Globalization;
using ExInterfaces.Entities;

List<Installment> instalments = new List<Installment>();

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Contract contract = new Contract(number, date, contractValue);

Console.WriteLine("Enter number of installments: ");
int installments = int.Parse(Console.ReadLine());

for (int i = 1; i <= installments; i++)
{
    instalments.Add();
}
