// See https://aka.ms/new-console-template for more information

using ex002Classes;

Funcionario funcionario1, funcionario2;

Console.WriteLine("Primeiro funcionario:");

funcionario1 = new Funcionario();

funcionario1.Nome = Console.ReadLine();
funcionario1.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("Segundo funcionario:");

funcionario2 = new Funcionario();

funcionario2.Nome = Console.ReadLine();
funcionario2.Salario = double.Parse(Console.ReadLine());

double mediaSal = (funcionario1.Salario + funcionario2.Salario) / 2;

Console.WriteLine(mediaSal);

