// See https://aka.ms/new-console-template for more information
using ex2MetodosAbstratos.Entities;
using System.Globalization;

Console.WriteLine("Enter the numbewr of tax payers: ");
int n = int.Parse(Console.ReadLine());

List<TaxPayer> list = new List<TaxPayer>();

for (int i = 0; i < n; i++)
{
    Console.Write("Individual or Company (i/c)?");
    char ch = char.Parse(Console.ReadLine());
    if (ch == 'i')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual Income: ");
        double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Healthy expeditures: ");
        double HealthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Individual(name, anualIncome, HealthExpeditures));
    }
    else
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual Income: ");
        double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Number of Employees: ");
        int numberOfEmplyees = int.Parse(Console.ReadLine());

        list.Add(new Company(name, anualIncome, numberOfEmplyees));
    }
}

Console.WriteLine();
Console.WriteLine("TAX PAID: ");
foreach (TaxPayer emp in list)
{
    Console.WriteLine(emp.Name + ": $ " + emp.Tax().ToString("F2", CultureInfo.InvariantCulture));
}

Console.WriteLine();
Console.Write("TOTAL TAXES: $ ");

double tax = 0;
foreach (TaxPayer emp in list)
{
    tax += emp.Tax();
}
Console.WriteLine(tax.ToString("F2", CultureInfo.InvariantCulture));


