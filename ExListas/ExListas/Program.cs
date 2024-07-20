// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Collections.Generic;
using ExListas;

Console.Write("How many employes will be registred? ");
int r = int.Parse(Console.ReadLine());

List<Employee> funcionarios = new List<Employee>();

for (int i = 0; i < r; i++)
{
    Console.WriteLine("Employee #" + i + ":");

    Console.WriteLine("ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.WriteLine("Name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    funcionarios.Add(new Employee(id, name, salary));
    Console.WriteLine(" ");

}

Console.WriteLine("Enter the employee id that will have salary increase : ");
int searchId = int.Parse(Console.ReadLine());

Employee emp = funcionarios.Find(x => x.Id == searchId);

if(emp != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.icreaseSalary(percentage);
}
else
{
    Console.WriteLine("This id is does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list: ");


foreach (Employee item in funcionarios)
{
    Console.WriteLine(item);
}











