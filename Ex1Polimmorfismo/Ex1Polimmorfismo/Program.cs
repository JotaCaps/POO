// See https://aka.ms/new-console-template for more information
using Ex1Polimmorfismo.Entities;
using System.Globalization;

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

List<Employee> list = new List<Employee>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data: ");
    Console.Write("Outsourced (y/n)?");
    string r = (Console.ReadLine());
    if (r == "n")
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value per hours: ");
        double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Employee(name, hours, valuePerHours));
    }
    else
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value per hors: ");
        double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Additional charge: ");
        double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new OutsourcedEmployee(name, hours, valuePerHours, addCharge));
    }

}

Console.WriteLine("Payments: ");
foreach (Employee obj in list)
{
    Console.WriteLine(obj);
}
