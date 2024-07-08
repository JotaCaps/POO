// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Ex002ClassesMetodosAtributos;

Funcionario f = new Funcionario();

Console.WriteLine("Digite o nome o salário e o imposto do funcionario: ");
f.Nome = Console.ReadLine();
f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Funcionário: " + f);

Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(pct);

Console.WriteLine("Dados atualizados: " + f);


