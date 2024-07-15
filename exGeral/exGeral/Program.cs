// See https://aka.ms/new-console-template for more information
using exGeral;
using System.Globalization;

Conta conta;

Console.WriteLine("Entre com o número da conta: ");
int c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre o titular da conta: ");
string n = Console.ReadLine();

Console.WriteLine("Havera deposito inicial? [S/N]");
string r = Console.ReadLine();

if (r == "s" || r == "s")
{
    Console.WriteLine("Entre o valor do depósito inicial: ");
    double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    conta = new Conta(c, n, d);

    Console.WriteLine("Dados da conta: ");
    Console.WriteLine(conta);
}
else
{
    conta = new Conta(c, n);
}

 Console.WriteLine("Entre um valor para deposito: ");
 double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

 conta.Deposito(deposito);

 Console.WriteLine("Dados atualizados: ");
 Console.WriteLine(conta);

 Console.WriteLine("Entre um valor para saque: ");
 double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

 conta.Saque(saque);

 Console.WriteLine("Dados atualizados: ");
 Console.WriteLine(conta);







